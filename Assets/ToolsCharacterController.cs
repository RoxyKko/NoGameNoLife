using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsCharacterController : MonoBehaviour
{
    CharacterController2D character;
    RigidBody2D rgbd2d;

    void Awake()
    {
        character = GetComponent<CharacterController2D>();
        rgbd2d = GetComponent<RigidBody2D>();
    }
}
