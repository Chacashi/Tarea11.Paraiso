using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubickControl : MonoBehaviour
{
	Rigidbody2D _compRigidbody2D;
	SpriteRenderer _compSpriteRenderer;
	public float xDirection;
	public float yDirection;
	public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
	_compSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
       _compRigidbody2D.velocity = new Vector2(speed* xDirection, speed* yDirection);
	
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
     if(collision.gameObject.tag == "Horizontal"){
	xDirection = xDirection * -1;
	if(_compSpriteRenderer.flipX == true){
	_compSpriteRenderer.flipX= false;
	}
	else{
	_compSpriteRenderer.flipX= true;
	}
	if(_compSpriteRenderer.flipY == true){
	_compSpriteRenderer.flipY= false;
	}
	else{
	_compSpriteRenderer.flipY= true;
	}
	}
     if(collision.gameObject.tag == "Vertical"){
	yDirection = yDirection * -1;
	if(_compSpriteRenderer.flipX == true){
	_compSpriteRenderer.flipX= false;
	}
	else{
	_compSpriteRenderer.flipX= true;
	}
	if(_compSpriteRenderer.flipY == true){
	_compSpriteRenderer.flipY= false;
	}
	else{
	_compSpriteRenderer.flipY= true;
	}
	
	}
    }
    
}
