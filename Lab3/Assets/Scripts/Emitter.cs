using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshCollider))]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class Emitter : MonoBehaviour {

    public Particle particlePrefab;
    private Particle ball;

    public int particleCount = 0;
    public bool sharedVertices = false;

    public bool emitting = false;

    public void Awake() {
        MeshFilter mFilter = GetComponent<MeshFilter>();
        if (mFilter == null) {
            Debug.LogError("MeshFilter not found!");
            return;
        }

        Vector3 p0 = new Vector3(0, 0, 0);
        Vector3 p1 = new Vector3(1, 0, 0);
        Vector3 p2 = new Vector3(0.5f, 0, Mathf.Sqrt(0.75f));
        Vector3 p3 = new Vector3(0.5f, Mathf.Sqrt(0.75f), Mathf.Sqrt(0.75f) / 3);

        Mesh m = mFilter.sharedMesh;
        if (m == null) {
            mFilter.mesh = new Mesh();
            m = mFilter.sharedMesh;
        }
        m.Clear();
        if (sharedVertices) {
            m.vertices = new Vector3[] { p0, p1, p2, p3 };
            m.triangles = new int[]{
                0,1,2,
                0,2,3,
                2,1,3,
                0,3,1
            };
            m.uv = new Vector2[]{
                new Vector2(0,0),
                new Vector2(1,0),
                new Vector2(0,1),
                new Vector2(1,1),
            };
        } else {
            m.vertices = new Vector3[]{
                p0,p1,p2,
                p0,p2,p3,
                p2,p1,p3,
                p0,p3,p1
            };
            m.triangles = new int[]{
                0,1,2,
                3,4,5,
                6,7,8,
                9,10,11
            };

            Vector2 uv0 = new Vector2(0, 0);
            Vector2 uv1 = new Vector2(1, 0);
            Vector2 uv2 = new Vector2(0.5f, 1);

            m.uv = new Vector2[]{
                uv0,uv1,uv2,
                uv0,uv1,uv2,
                uv0,uv1,uv2,
                uv0,uv1,uv2
            };

        }

        m.RecalculateNormals();
        m.RecalculateBounds();
        beginEmitting();
    }

    void beginEmitting() {
        print("we made it ");
        int i = 0;
        if (particleCount == 0) {
            while (i < 30) {
                createParticle();
                i++;
                particleCount++;
                delayTimer();
            }
        } else {
            createParticle();
        }
    }

    IEnumerator delayTimer() {
        yield return new WaitForSeconds(0.4f);
    }


    void createParticle() {
        ball = Instantiate(particlePrefab) as Particle;
        ball.velocity.y = Random.Range(-20f, 0);
        ball.velocity.x = Random.Range(0f, 2f);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.R)) {
            print("r was pressed");
            if (emitting) {
                emitting = false;
            } else {
                beginEmitting();
                emitting = true;
            }
        }
        if(emitting) {
            createParticle();
        }
    }
}
