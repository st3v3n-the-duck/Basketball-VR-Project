using UnityEngine;

public class PlayerPosition : MonoBehaviour
{


  
    public int Zone = 3;
    private int _currentZone = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Zone"))
        {
            _currentZone = other.GetComponent<Zone>().ZoneNumber;
        }
    }

   private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Zone"))
        {
            if (_currentZone == 1)
            {
                _currentZone = 2;
                return;
            }
            if (_currentZone == 2)
            {
                _currentZone = 3;
                return;
            }

        }
    }
   
    private void Update()
    {
        Debug.Log("Current Zone: " + _currentZone);
    }
    private void Awake()
    {
        Zone = 3;
        _currentZone= 3;
    }

    public void BallRelease()
    {
        Zone = _currentZone;
    }



}
