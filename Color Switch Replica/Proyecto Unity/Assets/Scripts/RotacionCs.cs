using UnityEngine;

public class RotacionCs : MonoBehaviour {
	[Header("Script de rotacion 5ontrol by kike")]
	[Space(15)]
	public float VelocidadDeRotacion = 100f;

	void Update () 
	{
		transform.Rotate (0f,0f,VelocidadDeRotacion * Time.deltaTime);
	}
}
