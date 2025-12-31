using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField]private GameManager gameManager;
    private TextMeshProUGUI textMesh;
    
    private void Awake()
    {

        
        textMesh = GetComponentInChildren<TextMeshProUGUI>();
    }
    private void Update()
    {
        textMesh.text = gameManager.score + "\n" + "P" + gameManager.playerLife; 
        
    }
}
