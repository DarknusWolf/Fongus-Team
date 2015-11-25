using UnityEngine;
using System.Collections;

public class caracol : MonoBehaviour{

    RaycastHit hit;
    private float distanceToGround = 0;
    private float distanceToFront = 0;
    public LayerMask capa;
    public Transform offset;
    public float distancia = 1f;
    public float horizontal = 5f;
    public float vertical = 10f;
    public float maxVelocity = 10f;
    private Vector3 delante;
    private Vector3 abajo;

    public Quaternion from;
    public Quaternion to;
    // Use this for initialization

    Rigidbody2D rg;
    void Start(){
        rg = GetComponent<Rigidbody2D>();
        from = transform.rotation;
        to = transform.rotation;
    }

    // Update is called once per frame
    void Update(){
        from = transform.rotation;
        delante = transform.TransformDirection(Vector3.right) * distancia;
        abajo = transform.TransformDirection(-Vector3.up) * distancia;

        RaycastHit2D hitdown = Physics2D.Raycast(offset.position, abajo, distancia, capa);
        if (hitdown.collider != null){
            Debug.DrawLine(offset.position, hitdown.point, Color.green);
            distanceToGround = hitdown.distance;
            Debug.Log(hitdown.transform.name);

            if (rg.velocity.magnitude < maxVelocity){
                rg.AddForce(delante.normalized * horizontal);
            }
        }
        else{
            Debug.DrawRay(offset.position, abajo, Color.red);
            rg.velocity = Vector3.zero;
        }

        RaycastHit2D hit = Physics2D.Raycast(offset.position, delante, distancia, capa);
        if (hit.collider != null){
            Debug.DrawLine(offset.position, hit.point, Color.green);
            distanceToFront = hit.distance;
            Debug.Log(hit.transform.name);
            if (rg.velocity.magnitude < maxVelocity){
                rg.AddForce(abajo.normalized * vertical);
			}
        }

        else{
            Debug.DrawRay(offset.position, delante, Color.red);
        }

        if (hit.collider != null && to == from){
            to = Quaternion.AngleAxis(transform.rotation.eulerAngles.z + 90, Vector3.forward);
        }
        if (hitdown.collider == null && hit.collider == null && to == from){
            to = Quaternion.AngleAxis(transform.rotation.eulerAngles.z - 90, Vector3.forward);
        }

        if (to != from){
            transform.rotation = Quaternion.Lerp(from, to, Time.deltaTime * 5);
        }
    }
}
