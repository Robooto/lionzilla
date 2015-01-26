using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Gizmo : MonoBehaviour {

    public Color color = new Color(0.985f, 0.022f, 0.2f);
    public List<GameObject> targets = new List<GameObject>();
    public Vector3 size = new Vector3(1, 1, 0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDrawGizmos()
    {
        Gizmos.color = color;
        Gizmos.DrawCube(transform.position, size);

        if (targets.Count > 0)
        {
            for (int i = 0; i < targets.Count; i++)
            {
                Gizmos.DrawLine(transform.position, targets[i].transform.position);
            }
        }
    }

    public GameObject GetRandomTarget()
    {
        if (targets.Count == 0)
            return null;

        return targets[Random.Range(0, targets.Count)];
        
    }

    public GameObject GetTargetAt(int index)
    {
        if (targets.Count == 0)
            return null;

        return targets[index];
    }
}
