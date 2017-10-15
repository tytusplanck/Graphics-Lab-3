using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Emitter))]
public class PyramidCreator : Editor {
    [MenuItem("GameObject/Create Other/Pyramid")]
    static void Create() {
        GameObject gameObject = new GameObject("Emitter");
        Emitter py = gameObject.AddComponent<Emitter>();
        MeshFilter meshFilter = gameObject.GetComponent<MeshFilter>();
        meshFilter.mesh = new Mesh();
        py.Awake();
    }
}
