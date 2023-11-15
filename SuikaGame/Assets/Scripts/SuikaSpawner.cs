using System.Collections.Generic;
using Suika;
using UnityEngine;
using UnityEngine.InputSystem;

public class SuikaSpawner : MonoBehaviour
{
    [SerializeField] private GameObject suikaPrefab;
    [SerializeField] private InputActionReference click;

    [SerializeField] private List<SuikaObject> suikas = new();
    
    private GameObject container;

    private void Awake()
    {
        click.action.performed += SpawnBall;

        container = null;

        if (suikas.Count == 0)
        {
            Debug.LogWarning($"No {nameof(SuikaObject)} assigned to {nameof(suikas)} on {nameof(SuikaSpawner)}!");
        }
    }

    private void SpawnBall(InputAction.CallbackContext callbackContext)
    {
        if (container == null)
        {
            container = Instantiate(new GameObject());
            container.name = "BallContainer";
        }
        
        GameObject a = Instantiate(suikaPrefab);
        if (a.TryGetComponent(out SuikaPrefab found))
        {
            found.Instantiate(suikas[Random.Range(0, suikas.Count)].SuikaInfo);
        }
        else
        {
            Debug.LogWarning($"{nameof(this.suikaPrefab)} does not have a {nameof(SuikaPrefab)} script attached!");
        }
        
        
        
        a.transform.position = transform.position;
        a.transform.parent = container.transform;
    }
}
