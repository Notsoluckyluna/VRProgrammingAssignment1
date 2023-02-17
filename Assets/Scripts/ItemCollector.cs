using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ItemCollector : MonoBehaviour
{
    int cheese = 0;

    [SerializeField] Text cheesetext;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cheese"))
        {
            Destroy(other.gameObject);
            cheese++;
            Debug.Log("Cheese:" + cheese);

            if (cheese >= 5)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            }

        }





      
    }

    

}
