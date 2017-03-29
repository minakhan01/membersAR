using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linTestScript : MonoBehaviour {

    public Vector3 ArrowOrigin;
    public Vector3 ArrowTarget;
    private LineRenderer cachedLineRenderer;

    // Use this for initialization
    void Update () {
		
	}
	
	// Update is called once per frame
	void Start () {
        Vector3 ArrowOrigin = transform.position;
        Vector3 ArrowTarget = transform.position + new Vector3(0.2f,0.2f,0 );
        cachedLineRenderer = this.GetComponent<LineRenderer>();
        cachedLineRenderer.widthCurve = new AnimationCurve(
            new Keyframe(0, 0.1f)
            , new Keyframe(0f, 0.4f) // neck of arrow
            , new Keyframe(0f, 1f)  // max width of arrow head
            , new Keyframe(1, 0f));  // tip of arrow
        cachedLineRenderer.SetPositions(new Vector3[4] {
             ArrowOrigin
            // , Vector3.Lerp(ArrowOrigin, ArrowTarget, 0.5f)
            // , Vector3.Lerp(ArrowOrigin, ArrowTarget, 0.5f)
             , ArrowTarget
             , ArrowTarget + new Vector3(0.1f, 0.1f, 0.1f)
             , ArrowTarget + new Vector3(0.5f, 0.5f, 0.5f)




        });
        cachedLineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        // A simple 2 color gradient with a fixed alpha of 1.0f.
        float alpha = 1.0f;
        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(Color.green, 0.0f), new GradientColorKey(Color.red, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
            );
        cachedLineRenderer.colorGradient = gradient;
    }
}
