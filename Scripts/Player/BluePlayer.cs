using UnityEngine;

public class BluePlayer : MonoBehaviour
{
    [SerializeField] float speedAmount;
    [SerializeField] float maxSpeed;
    Rigidbody2D rig;
    float speed_x;
    SpriteRenderer spriteRenderer;
    Animator animator;
    bool isDying;
    [SerializeField] Pause pause;
    [SerializeField] GameObject failCanvas;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        speed_x = 0;
    }
    private void OnEnable()
    {
        isDying = false;
        rig.freezeRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        if (isDying)
        {
            rig.freezeRotation = true;
            rig.velocity = Vector2.zero;
            return;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift)){
            animator.SetTrigger("Reverse");
            if(rig.velocity.y < 0.01 && rig.velocity.y > -0.01) {
                rig.gravityScale = -rig.gravityScale;
            }
        }
        else if(Input.GetKey(KeyCode.A)){
            spriteRenderer.flipX = true;
            if(speed_x > 0) speed_x = 0;
            else if(speed_x >= -maxSpeed) speed_x -= speedAmount;
        }
        else if(Input.GetKey(KeyCode.D)){
            spriteRenderer.flipX = false;
            if(speed_x < 0) speed_x = 0;
            if(speed_x <= maxSpeed) speed_x += speedAmount;
        }
        else{
            speed_x = 0;
        }

        rig.velocity = new Vector2(speed_x, rig.velocity.y);
    }

    public void Die()
    {
        isDying = true;
        animator.SetTrigger("Die");
        Invoke("Disappear", 1.239f);
    }

    private void Disappear()
    {
        pause.PauseGame();
        failCanvas.SetActive(true);
        gameObject.SetActive(false);
    }
}
