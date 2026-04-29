using UnityEngine;

public class ChangeStateScript : MonoBehaviour
{
    private Animator myAnimator;
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            myAnimator.SetTrigger(name: "DoJump");
        }
        if (Input.GetKey(KeyCode.D))
        {
            myAnimator.SetBool(name: "DoRun", value: true);

            Vector3 scale = transform.localScale;
            scale.x = Mathf.Abs(scale.x);
            transform.localScale = scale;
        }
        if (Input.GetKey(KeyCode.A))
        {
            myAnimator.SetBool(name: "DoRun", value: true);

            Vector3 scale = transform.localScale;
            scale.x = -Mathf.Abs(scale.x);
            transform.localScale = scale;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            myAnimator.SetBool(name: "DoRun", value: false);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            myAnimator.SetBool(name: "DoRun", value: false);
        }
    }
}
