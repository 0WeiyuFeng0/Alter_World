using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text score_Text;
    public Text coin_Text;
    public Text live_Text;
    public GameObject end_score;
    public GameObject end_coin;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        score_Text.text = "Score: " + global_variable.score.ToString("F0");
        coin_Text.text = "x " + global_variable.getcoins.ToString();
        live_Text.text = "x " + global_variable.live.ToString();
        end_score.GetComponent<TMPro.TextMeshProUGUI>().text = "Score: " + global_variable.score.ToString("F0");
        end_coin.GetComponent<TMPro.TextMeshProUGUI>().text = "x " + global_variable.getcoins.ToString();
    }
}
