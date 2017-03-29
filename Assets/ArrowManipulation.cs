using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManipulation : MonoBehaviour {

    public GameObject ArrowHead;
    public GameObject ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setPositions(Vector3 positions) {
        // positions = new Vector3(0.5f, 0, 0);
        Transform cameraTransform = Camera.main.transform;
        //  Vector3 startPosition = cameraTransform.position + new Vector3(0, 0, 1);
        Vector3 startPosition = ball.transform.position;
        Vector3 lineEndPosition = startPosition + 0.6f*positions;
        Vector3 arrowEndPosition = lineEndPosition + 0.2f*positions;
        LineRenderer lr = this.GetComponent<LineRenderer>();
        lr.SetPositions(new Vector3[] {
            startPosition,
            lineEndPosition
        });
        lr.widthCurve = new AnimationCurve(new Keyframe(0, 0.1f));
        LineRenderer arrowHeadLineRenderer = ArrowHead.GetComponent<LineRenderer>();
        arrowHeadLineRenderer.SetPositions(new Vector3[] {
        lineEndPosition,
        arrowEndPosition
        });
        arrowHeadLineRenderer.widthCurve = new AnimationCurve(new Keyframe(0, 0.3f), new Keyframe(1, 0));


    }
}
