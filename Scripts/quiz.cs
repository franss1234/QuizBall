using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class quiz : MonoBehaviour
{

    public TextMeshProUGUI questionText;
    double time = 0;
    int counter = 0;

    questions question = new questions();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;

        if (time > 4.0)
        {
            //GameObject.Find("ButtonBehaviour").GetComponent<buttonBehaviour>().questionLoop();
            questionText.text = question.ask_animal;
            /*if(yes()){
              questionText.text = question.ask_carnivour;
            }*/


        }
        if(counter > 0){
          Debug.Log(counter);
        }
    }
/*
    // return something
    int yes(int num)
    {
        question.animal.Add(num);
        return num;
    }
*/

    public void yes()
    {
      counter++;
      question.
    }


}
