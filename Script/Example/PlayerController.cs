using UnityEngine;

/// <summary>
/// This is the class for controlling the player's movement
/// </summary>
public class PlayerController : MonoBehaviour {

    // Player speed
    public float Speed = 1;

    // Rigidbody player
    private Rigidbody2D _rigidbody;

	void Start () {

        _rigidbody = GetComponent<Rigidbody2D>();

        if (_rigidbody == null)
            Debug.LogWarning("Error initializing the player.Rigidbody not found!");

    }

	void Update () {

        if (_rigidbody == null)
            return;

        float horizontalAxist = Input.GetAxis("Horizontal");
        float verticalAxist = Input.GetAxis("Vertical");

        Vector3 moveNext = new Vector3(horizontalAxist, verticalAxist);

        _rigidbody.MovePosition(transform.position + moveNext * Speed * Time.deltaTime);

    }

}
