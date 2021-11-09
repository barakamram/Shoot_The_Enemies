using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component reades the "playerScore" static variable from the GAME_STATUS static class into this object's number field.
 */
[RequireComponent(typeof(NumberField))]
public class GameStatusReader : MonoBehaviour {
    void Start() {
        GetComponent<NumberField>().SetNumber(GAME_STATUS.playerScore);
    }
}
