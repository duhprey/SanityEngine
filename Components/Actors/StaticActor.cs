using UnityEngine;
using System.Collections;

[AddComponentMenu("Sanity Engine/Actors/Static Actor")]
public class StaticActor : GameObjectActor {
	Transform xform;
	
	void Start () {
		xform = transform;
	}
	
	public override Vector3 Velocity
    {
        get { return Vector3.zero; }
    }

	public override Vector3 AngularVelocity
    {
        get { return Vector3.zero; }
    }
	
    public override Vector3 Position
    {
        get { return xform.position; }
    }

    public override Vector3 Forward
    {
        get { return xform.forward; }
    }

	public override Vector3 Right
    {
        get { return xform.right; }
    }
    
	public override Vector3 Up
    {
        get { return xform.up; }
    }
}
