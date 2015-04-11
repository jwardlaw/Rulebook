/* Copyright (c) 2014 Advanced Platformer 2D */
using UnityEngine;

public class APCharacterEventListener : MonoBehaviour
{
	public virtual void OnTouchGround() {}
	public virtual void OnLeaveGround() {}
	public virtual void OnJump() {}

	public virtual void OnGlideStart() {}
	public virtual void OnGlideEnd() {}

	public virtual void OnWallSlideStart() {}
	public virtual void OnWallSlideEnd() {}

	public virtual void OnCrouchStart() {}
	public virtual void OnCrouchEnd() {}

	public virtual void OnWallJumpStart() {}
	public virtual void OnWallJumpEnd() {}

	public virtual void OnMeleeAttackStart(APMeleeAttack attack) {}
	public virtual void OnMeleeAttackHit(APMeleeAttack attack, APHitable hitObject) {}
	public virtual void OnMeleeAttackEnd(APMeleeAttack attack) {}

	public virtual void OnRangedAttackStart(APRangedAttack attack) {}
	public virtual void OnRangedAttackFired(APRangedAttack attack, APBullet bullet) {}
	public virtual void OnRangedAttackEnd(APRangedAttack attack) {}

	public virtual void OnShiftStart() {}
	public virtual void OnShiftEnd() {}

	public virtual void OnEdgeGrabStart(APEdgeGrab grabObject) {}
	public virtual void OnEdgeGrabEnd(APEdgeGrab grabObject) {}

	public virtual void OnLadderCatch(APLadder ladder) {}
	public virtual void OnLadderRelease(APLadder ladder) {}

	public virtual void OnRailingsCatch(APRailings railings) {}
	public virtual void OnRailingsRelease(APRailings railings) {}

}


