﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingStateBehaviour : StateMachineBehaviour {

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		Guard guardAI = animator.gameObject.GetComponent<Guard>();
		guardAI.ToggleWaiting();
	}
	
	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		Guard guardAI = animator.gameObject.GetComponent<Guard>();
		guardAI.ToggleWaiting();
	}
}
