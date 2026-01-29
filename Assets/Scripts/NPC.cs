using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public abstract class NPC : MonoBehaviour, IInteractable
{
    [SerializeField] private SpriteRenderer _interactSprite;

    private Transform _playerTransform;

    private const float INTERACT_DISTANCE = 2f;

    private void Start()
    {
        _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame && IsWithinInteractDistance())
        {
            //interact with npc
            Interact();
        }

        if(_interactSprite.gameObject.activeSelf && !IsWithinInteractDistance())
        {
            //turn off sprite
            _interactSprite.gameObject.SetActive(false);
        }
        else if(!_interactSprite.gameObject.activeSelf && IsWithinInteractDistance())
        {
            //turn on sprite
            _interactSprite.gameObject.SetActive(true);
        }
    }

    public abstract void Interact();

    private bool IsWithinInteractDistance()
    {
        if(Vector2.Distance(_playerTransform.position, transform.position) < INTERACT_DISTANCE)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
