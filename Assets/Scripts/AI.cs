using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
    float  speed = 0.5f;
    // TODO: AI sTuFF



	void Update () {
        Vector3 pos = this.transform.position;
        pos += new Vector3(1 * speed ,0,0 ) * Time.deltaTime;
        transform.position = pos;
	}
}
