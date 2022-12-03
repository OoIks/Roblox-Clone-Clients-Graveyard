using Mirror;

public class PlayerController : NetworkBehaviour
{
	public float speed;
	public float jumpForce;
	public float turnSmoothing;
	public float groundOffset;
	public float currentHealth;
	public float maxHealth;
	public float minJumpDelay;
	public float deathRandomTorqueRange;
	public float deathPositionRange;
	public float deathExplosionForce;
	public float respawnDelay;
	public bool movementDisabled;
}
