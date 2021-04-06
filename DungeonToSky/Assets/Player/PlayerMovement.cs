using UnityEngine;

public class PlayerMovement : Player
{
    // Update is called once per frame
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonUp("Fire1"))
        {
            this.Attack();
        }
    }

    void FixedUpdate()
    {
        player.MovePosition(player.position + Movement * Stats.movementSpeed * Time.fixedDeltaTime);
        if (Movement.x > 0)
        {
            Facing = true;
            Sr.flipX = Facing;
        }
        else if (Movement.x < 0)
        {
            Facing = false;
            Sr.flipX = Facing;
        }
    }
}
