using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    [SerializeField] bool ShowDebugLog = false;
    
    // Dependencies
    private ILocomotion _locomotion;

    // Start is called before the first frame update
    void Start()
    {
        _locomotion = transform.GetComponent<ILocomotion>();

        if (_locomotion == null)
        {
            Debug.LogError("ILocomotion not found on " + gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(_locomotion != null)
        {
            _locomotion.Horizontal = Input.GetAxisRaw("Horizontal");
            _locomotion.Vertical = Input.GetAxisRaw("Vertical");
        }
    }
}
