using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerScript : MonoBehaviour {

	[Header("Script Color Switch 5ontrol by kike")]
	[Space(15)]

	public float FuerzaVertical = 5f;
	[Header("Rigid body del player")]
	public Rigidbody2D RigidBody2D;
	[Header("Sprite del player")]
	public SpriteRenderer SpriteRenderPlayer;
	private string ColorDefinido;
	[Header("Colores para el player")]
	public Color Color1;
	public Color Color2;
	public Color Color3;
	public Color Color4;

	public string[] TagsParaJueg = new string[] { };

	public string[] tagsStr = UnityEditorInternal.InternalEditorUtility.tags;








	void Awake () {
		Application.targetFrameRate = 300;
	}


	void Start ()
	{
		RandomColorF ();
	}


	void Update () 
	{
		if (Input.GetButtonDown ("Jump") || Input.GetMouseButtonDown (0)) 
		{
			RigidBody2D.velocity = Vector2.up * FuerzaVertical;
		}
	}


	void OnTriggerEnter2D (Collider2D col)
	{

		if (col.tag == TagsParaJueg[0])
		{
			RandomColorF ();
			Destroy (col.gameObject);
			return;
		}

		if (col.tag != ColorDefinido) 
		{
			Debug.Log ("GAME OVER");
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}

	}


	void RandomColorF ()
	{
		int index = Random.Range (0, 4);

		switch (index) 
		{
		case 0:
			ColorDefinido = TagsParaJueg[1];
			SpriteRenderPlayer.color = Color1;
			break;
		case 1:
			ColorDefinido = TagsParaJueg[2];
			SpriteRenderPlayer.color = Color2;
			break;
		case 2:
			ColorDefinido = TagsParaJueg[3];
			SpriteRenderPlayer.color = Color3;
			break;
		case 3:
			ColorDefinido = TagsParaJueg[4];
			SpriteRenderPlayer.color = Color4;
			break;
		}
	}
}
