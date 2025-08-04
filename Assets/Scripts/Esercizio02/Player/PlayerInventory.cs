using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class PlayerInventory : MonoBehaviour
{
    //public SO_Item[] inventoryItems;
    public List<SO_Item> inventoryItems = new List<SO_Item>();

    private static PlayerInventory _instance;

    [SerializeField] private GameObject _player;

    public static PlayerInventory Instance
    {
        get
        {
            CreateOrGetInstance();
            return _instance;
        }
    }

    private static void CreateOrGetInstance()
    {
        if (_instance == null)
        {
            _instance = FindObjectOfType<PlayerInventory>();
            if (_instance == null)
            {
                GameObject newInventory = new GameObject("PlayerInventory");
                newInventory.AddComponent<PlayerInventory>();
                _instance = newInventory.GetComponent<PlayerInventory>();
                DontDestroyOnLoad(newInventory);
            }
        }
    }

    private void OnDestroy()
    {
        if (_instance == this)
        {
            _instance = null; // Rimuove l'istanza quando questo oggetto viene distrutto
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != null)
        {
            Debug.LogWarning("Esiste già un'istanza di PlayerInventory, distruggo questo oggetto.");
            Destroy(gameObject);
        }
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject); 
            Debug.Log("Istanza di PlayerInventory creata e marcata per non essere distrutta tra le scene.");
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if (_player == null)
            Debug.Log("Manca il player!");
    }

    private void Update()
    {
        if (inventoryItems.Count > 0 && _player != null)
        {
            int value = -1;
            for (int i = 0; i <= 9; i++)
            {
                KeyCode main = (KeyCode)((int)KeyCode.Alpha0 + i);
                KeyCode pad = (KeyCode)((int)KeyCode.Keypad0 + i);

                if (Input.GetKeyDown(main) || Input.GetKeyDown(pad))
                {
                    value = i;
                    inventoryItems[value].Use(_player);
                    break; // Uscita anticipata: abbiamo trovato il numero
                }
            }
        }
        if (inventoryItems.Count > 0 && inventoryItems != null )
        {
            for (int i = 0; i < inventoryItems.Count; i++)
            {
                Debug.Log(inventoryItems[i]);
            }
        }
    }



}
