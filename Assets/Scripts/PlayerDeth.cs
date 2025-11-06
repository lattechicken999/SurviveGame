using UnityEngine;
using UnityEngine.UI;

public class PlayerDeth : MonoBehaviour
{
    [SerializeField] private RawImage _endGameImage;

    private void Start()
    {

        _endGameImage.enabled = false;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ghost"))
        {
            gameObject.SetActive(false);
            _endGameImage.enabled = true;
        }
    }
}
