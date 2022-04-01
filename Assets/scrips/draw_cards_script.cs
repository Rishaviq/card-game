using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draw_cards_script : MonoBehaviour
{
    public GameObject[] cards = new GameObject[5];
    
    public GameObject card_poison;
    public GameObject card_warrior;
    public GameObject card_fireball;
    public GameObject card_exodia;
    public GameObject card_dragon;
    public GameObject player_area;
    public GameObject enemy_area;
    System.Random rand = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < 5; i++) {
            cards[i] = new GameObject();
          
        }
        cards[0] = card_poison;
        cards[1] = card_warrior;
        cards[2] = card_fireball;
        cards[3] = card_exodia;
        cards[4] = card_dragon;


       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick() {
        GameObject playerCard = Instantiate(cards[rand.Next(0,5)],new Vector3(0,0,0),Quaternion.identity);
        playerCard.transform.SetParent(player_area.transform, false);
    
    }
}
