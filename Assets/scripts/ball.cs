using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public GameplayUIManager _GameplayUIManager;
    public GameObject GameplayUIManager_GO;
    private Rigidbody _rb;
    [SerializeField] private int _score;
    [SerializeField] private int _speed;


    // Start is called before the first frame update
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _GameplayUIManager = GameplayUIManager_GO.GetComponent<GameplayUIManager>();



    }

    // Update is called once per frame
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //Add the force to the ball
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        _rb.AddForce(movement * _speed * Time.deltaTime, ForceMode.Impulse);

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collosion");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        if (other.gameObject.tag == "Pickable")
        {
            other.gameObject.SetActive(false);
            _score += 1;
            GameplayUIManager.Instance._scoretext.text = "score : " + _score;
        }
    }
}
