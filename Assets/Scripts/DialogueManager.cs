using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;

    public int phrase = 0;
    public int perso = 0;
    public int Bokchoix1;
    public int Bokchoix2;
    public int Bokchoix3;
    public int Bokchoix4;
    public int Bokchoix5;
    public int Bokchoix6;
    public int Bokchoix7;

    public bool calmos = false; 

    public GameObject parc;
    public GameObject ville;
    public GameObject marché;
    public GameObject restaurant;
    public GameObject ecrannoir;
    public GameObject supermarche;
    public GameObject salon;
    public GameObject chambre;
    public GameObject lit;
    public GameObject weeb;
    public GameObject prison;
    public GameObject suicidebok;
    public GameObject terv;
    public GameObject dogtir;
    public GameObject boktir;
    public GameObject bokmort;
    public GameObject temple;
    public GameObject couloir;
    public GameObject vestiaire;
    public GameObject bokcauchmar;
    public GameObject dadzyzy;
    public GameObject Brook;
    public GameObject Enfer;
    public GameObject Fuite;
    public GameObject BokChoix1;
    public GameObject BokChoix2;
    public GameObject BokChoix3;
    public GameObject BokChoix4;
    public GameObject BokChoix5;
    public GameObject BokChoix6;
    public GameObject BokChoix7;
    public GameObject Bokfin1;
    public GameObject Bokfin2;
    public GameObject Bokfin3;
    public GameObject Bokfin4;
    public GameObject Bokfin5;
    public GameObject Bokfin6;
    public GameObject Bokfin7;
    public GameObject Bokfin8;

    public Animator Spagr;
    public Animator Spagt;
    public Animator chong;
    public Animator KK;
    public Animator Bok;
    public Animator poireau;
    public Animator mrpoireau;
    public Animator brook;
    public Animator dog;
    public Animator zyzy;
    public Animator bokcauchemar;
    public Animator Parc;
    public Animator noir;
    public Animator supermarched;
    public Animator salonlon;
    public Animator chambrebok;
    public Animator litsekusu;
    public Animator weebanim;
    public Animator restauanim;
    public Animator tel;
    public Animator villeanim;
    public Animator suicideanim;
    public Animator tervanim;
    public Animator dogtiranim;
    public Animator boktiranim;
    public Animator bokmortanim;
    public Animator prisonanim;
    public Animator templeanim;
    public Animator couloiranim;
    public Animator vestiaireanim;
    public Animator dadzyzyanim;

    public SpriteRenderer ecrnoir;
    public SpriteRenderer parcsprite;
    public SpriteRenderer supersprite;
    public SpriteRenderer salonsprite;
    public SpriteRenderer chambresprite;
    public SpriteRenderer litsprite;
    public SpriteRenderer weebsprite;
    public SpriteRenderer restausprite;
    public SpriteRenderer villesprite;
    public SpriteRenderer suicidesprite;
    public SpriteRenderer tervsprite;
    public SpriteRenderer dogtirsprite;
    public SpriteRenderer boktirsprite;
    public SpriteRenderer bokmortsprite;
    public SpriteRenderer prisonsprite;
    public SpriteRenderer templesprite;
    public SpriteRenderer couloirsprite;
    public SpriteRenderer vestiairesprite;
    public SpriteRenderer dadzyzysprite;

    private Queue<string> sentences;
    private Queue<string> names;

    public ChoixManager choixmanager;


    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        names = new Queue<string>();
    }

  

    public void Bokz()
    {
        perso = 1;
        FindObjectOfType<AudioManager>().StopPlaying("MusiqueMenu");
        FindObjectOfType<AudioManager>().Play("MusiqueParc");
        Debug.Log("perso" + perso);
    }

    public void Kakaforce()
    {
        perso = 2;
        Debug.Log("perso" + perso);
    }

    public void Spagrat()
    {
        perso = 3;
        Debug.Log("perso" + perso);
    }

    public void Spagtor()
    {
        perso = 4;
        Debug.Log("perso" + perso);
    }

    public void choix (ChoixManager choixmanager)

    {
        Bokchoix1 = choixmanager.Bokchoix1;
        Bokchoix2 = choixmanager.Bokchoix2;
        Bokchoix3 = choixmanager.Bokchoix3;
        Bokchoix4 = choixmanager.Bokchoix4;
        Bokchoix5 = choixmanager.Bokchoix5;
        Bokchoix6 = choixmanager.Bokchoix6;
        Bokchoix7 = choixmanager.Bokchoix7;
    }


    public void StartDialogue(Dialogue dialogue)
    {

                chong.SetBool("Dialogue", true);
                choix(choixmanager);
                
        


                phrase = 0;



                sentences.Clear();

                foreach (string sentence in dialogue.sentences)
                {
                    sentences.Enqueue(sentence);
                }
                foreach (string name in dialogue.names)
                {
                    names.Enqueue(name);
                }
        
        
            DisplayNextSentence();
        
              
        

    }

    public void arrete()
    {
        if (calmos == false)
        {
            DisplayNextSentence();
        }
    }

    void Update()
    {
       
        
            if (calmos == false && BokChoix1.active == false && BokChoix2.active == false && BokChoix3.active == false && BokChoix4.active == false && BokChoix5.active == false && BokChoix6.active == false && BokChoix7.active == false)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    DisplayNextSentence();
                
                }
            }
        
    }


    IEnumerator parcsupermarche()
    {
        
        calmos = true;
        yield return new WaitForSeconds(1);
        Bok.SetBool("bok", false);
        chong.SetBool("Dialogue", false);
        parcsprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        Parc.SetBool("parcon", false);
        

        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        parcsprite.sortingOrder = 1;
        parc.SetActive(false);
        ecrnoir.sortingOrder = 2;
        supermarche.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);
        Bok.SetBool("bok", true);
        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        noir.SetBool("noiron", true);
        calmos = false;
    }


    IEnumerator supersalon()
    {

        calmos = true;
        yield return new WaitForSeconds(1);
        Bok.SetBool("bok", false);
        chong.SetBool("Dialogue", false);
        supersprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        supermarched.SetBool("superon", false);


        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        supersprite.sortingOrder = 1;
        supermarche.SetActive(false);
        ecrnoir.sortingOrder = 2;
        salon.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);
        Bok.SetBool("bok", true);
        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }

    IEnumerator salonchambre()
    {

        calmos = true;
        yield return new WaitForSeconds(1);
        Bok.SetBool("bok", false);
        chong.SetBool("Dialogue", false);
        salonsprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        salonlon.SetBool("saloon", false);


        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        salonsprite.sortingOrder = 1;
        salon.SetActive(false);
        ecrnoir.sortingOrder = 2;
        chambre.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);
        Bok.SetBool("bok", true);
        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }

    IEnumerator salonparc()
    {

        calmos = true;
        yield return new WaitForSeconds(1);
        Bok.SetBool("bok", false);
        chong.SetBool("Dialogue", false);
        salonsprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        salonlon.SetBool("saloon", false);


        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        salonsprite.sortingOrder = 1;
        salon.SetActive(false);
        ecrnoir.sortingOrder = 2;
        parc.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);
       
        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }

    IEnumerator chambrelit()
    {

        calmos = true;
        yield return new WaitForSeconds(1);
        Bok.SetBool("bok", false);
        chong.SetBool("Dialogue", false);
        chambresprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        chambrebok.SetBool("chambreon", false);


        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(5);
        chong.SetBool("Dialogue", false);
        yield return new WaitForSeconds(1);
        chambresprite.sortingOrder = 1;
        chambre.SetActive(false);
        ecrnoir.sortingOrder = 2;
        lit.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);
        DisplayNextSentence();
        yield return new WaitForSeconds(1);

        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }

    IEnumerator superweeb()
    {

        calmos = true;
        yield return new WaitForSeconds(1);
        
        chong.SetBool("Dialogue", false);
        supersprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        supermarched.SetBool("superon", false);


        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        supersprite.sortingOrder = 1;
        supermarche.SetActive(false);
        ecrnoir.sortingOrder = 2;
        weeb.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);
       
        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }


    IEnumerator weebrestau()
    {

        calmos = true;
        yield return new WaitForSeconds(3);

        chong.SetBool("Dialogue", false);
        weebsprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        weebanim.SetBool("weebon", false);


        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        weebsprite.sortingOrder = 1;
        weeb.SetActive(false);
        ecrnoir.sortingOrder = 2;
        restaurant.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);

        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }

    IEnumerator weebville()
    {

        calmos = true;
        yield return new WaitForSeconds(3);

        chong.SetBool("Dialogue", false);
        weebsprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        weebanim.SetBool("weebon", false);


        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        weebsprite.sortingOrder = 1;
        weeb.SetActive(false);
        ecrnoir.sortingOrder = 2;
        ville.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);

        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }

    IEnumerator villesuicide()
    {

        calmos = true;
        yield return new WaitForSeconds(3);

        chong.SetBool("Dialogue", false);
        villesprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        villeanim.SetBool("villeon", false);


        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        villesprite.sortingOrder = 1;
        ville.SetActive(false);
        ecrnoir.sortingOrder = 2;
        suicidebok.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);

        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }

    IEnumerator villeterv()
    {

        calmos = true;
        yield return new WaitForSeconds(3);

        chong.SetBool("Dialogue", false);
        villesprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        villeanim.SetBool("villeon", false);
        Bok.SetBool("bokmultion", false);
        KK.SetBool("kkonmulti", false);
        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        villesprite.sortingOrder = 1;
        ville.SetActive(false);
        ecrnoir.sortingOrder = 2;
        terv.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);
        Bok.SetBool("bok", true);
        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }

    IEnumerator villetemple()
    {

        calmos = true;
        yield return new WaitForSeconds(3);

        chong.SetBool("Dialogue", false);
        villesprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        villeanim.SetBool("villeon", false);
        Bok.SetBool("bokmultion", false);
        KK.SetBool("kkonmulti", false);
        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        villesprite.sortingOrder = 1;
        ville.SetActive(false);
        ecrnoir.sortingOrder = 2;
        temple.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);
        Bok.SetBool("bok", true);
        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }

    IEnumerator villeprison()
    {

        calmos = true;
        yield return new WaitForSeconds(3);

        chong.SetBool("Dialogue", false);
        villesprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        villeanim.SetBool("villeon", false);
        
        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        villesprite.sortingOrder = 1;
        ville.SetActive(false);
        ecrnoir.sortingOrder = 2;
        prison.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);
        
        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }

    IEnumerator templecouloir()
    {

        calmos = true;
        yield return new WaitForSeconds(3);
        zyzy.SetBool("zyzydecale", false);
        zyzy.SetBool("zyzyon", false);
        chong.SetBool("Dialogue", false);
        
        templesprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        templeanim.SetBool("templeon", false);

        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        templesprite.sortingOrder = 1;
        temple.SetActive(false);
        ecrnoir.sortingOrder = 2;
        couloir.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);

        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }

    IEnumerator templedadzyzy()
    {

        calmos = true;
        yield return new WaitForSeconds(3);
        zyzy.SetBool("zyzydecale", false);
        zyzy.SetBool("zyzyon", false);
        chong.SetBool("Dialogue", false);

        templesprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        templeanim.SetBool("templeon", false);

        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        templesprite.sortingOrder = 1;
        temple.SetActive(false);
        ecrnoir.sortingOrder = 2;
        dadzyzy.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);

        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }

    IEnumerator couloirvestiaire()
    {

        calmos = true;
        yield return new WaitForSeconds(3);

        chong.SetBool("Dialogue", false);
        couloirsprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        couloiranim.SetBool("couloiron", false);

        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        couloirsprite.sortingOrder = 1;
        couloir.SetActive(false);
        ecrnoir.sortingOrder = 2;
        vestiaire.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);

        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }

    IEnumerator terville()
    {

        calmos = true;
        yield return new WaitForSeconds(3);

        chong.SetBool("Dialogue", false);
        Bok.SetBool("hagar", false);
        Bok.SetBool("bok", false);
        tervsprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        tervanim.SetBool("tervon", false);
        Bok.SetBool("bokmultion", false);
        KK.SetBool("kkonmulti", false);
        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        tervsprite.sortingOrder = 1;
        terv.SetActive(false);
        ecrnoir.sortingOrder = 2;
        ville.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);
        
        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }


    IEnumerator parcville()
    {

        calmos = true;
        yield return new WaitForSeconds(3);

        chong.SetBool("Dialogue", false);
        parcsprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        Parc.SetBool("parcon", false);


        yield return new WaitForSeconds(3);
        DisplayNextSentence();
        parcsprite.sortingOrder = 1;
        parc.SetActive(false);
        ecrnoir.sortingOrder = 2;
        ville.SetActive(true);
        noir.SetBool("noiron", false);
        yield return new WaitForSeconds(1);

        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }

    IEnumerator tervmort()
    {

        calmos = true;
        yield return new WaitForSeconds(1);
        Bok.SetBool("hagar", false);
        Bok.SetBool("bok", false);
        dog.SetBool("dogded", false);
        dog.SetBool("dogon", false);
        chong.SetBool("Dialogue", false);
        tervsprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        tervanim.SetBool("tervon", false);


        yield return new WaitForSeconds(3);
        tervsprite.sortingOrder = 1;
        terv.SetActive(false);
        ecrnoir.sortingOrder = 2;
        dogtir.SetActive(true);
        noir.SetBool("noiron", false);
        DisplayNextSentence();
        yield return new WaitForSeconds(1);
        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(5);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        chong.SetBool("Dialogue", false);
        dogtirsprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        dogtiranim.SetBool("dogtiron", false);
        yield return new WaitForSeconds(3);
        dogtirsprite.sortingOrder = 1;
        dogtir.SetActive(false);
        ecrnoir.sortingOrder = 2;
        boktir.SetActive(true);
        noir.SetBool("noiron", false);
        DisplayNextSentence();
        yield return new WaitForSeconds(1);
        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(5);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        chong.SetBool("Dialogue", false);
        boktirsprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        boktiranim.SetBool("boktiron", false);
        yield return new WaitForSeconds(3);
        boktirsprite.sortingOrder = 1;
        boktir.SetActive(false);
        ecrnoir.sortingOrder = 2;
        bokmort.SetActive(true);
        noir.SetBool("noiron", false);
        DisplayNextSentence();
        yield return new WaitForSeconds(1);
        chong.SetBool("Dialogue", true);
        yield return new WaitForSeconds(2);
        ecrnoir.sortingOrder = 1;
        ecrannoir.SetActive(false);
        calmos = false;
    }


    IEnumerator FIN1BOK()
    {

        calmos = true;
        yield return new WaitForSeconds(3);
        Bok.SetBool("bokproche", false);
        Bok.SetBool("bok", false);
        chong.SetBool("Dialogue", false);
        litsprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        yield return new WaitForSeconds(1);
        litsekusu.SetBool("sekusuon", false);


        yield return new WaitForSeconds(3);
       
        litsprite.sortingOrder = 1;
        lit.SetActive(false);
        Bokfin1.SetActive(true);
        
        yield return new WaitForSeconds(5);
        Enfer.SetActive(true);
        Fuite.SetActive(true);
      
    }

    IEnumerator FIN2BOK()
    {

        calmos = true;
        yield return new WaitForSeconds(1);
        Bok.SetBool("bok", false);
        chong.SetBool("Dialogue", false);
        parcsprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        yield return new WaitForSeconds(1);
        Parc.SetBool("parcon", false);
        yield return new WaitForSeconds(3);
        parcsprite.sortingOrder = 1;
        parc.SetActive(false);
        Bokfin2.SetActive(true);
        yield return new WaitForSeconds(5);
        Enfer.SetActive(true);
        Fuite.SetActive(true);

    }

    IEnumerator FIN3BOK()
    {

        calmos = true;
        yield return new WaitForSeconds(1);
        Bok.SetBool("bok", false);
        chong.SetBool("Dialogue", false);
        restausprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        yield return new WaitForSeconds(1);
        restauanim.SetBool("restauon", false);
        yield return new WaitForSeconds(3);
        restausprite.sortingOrder = 1;
        restaurant.SetActive(false);
        Bokfin3.SetActive(true);
        yield return new WaitForSeconds(5);
        Enfer.SetActive(true);
        Fuite.SetActive(true);

    }

    IEnumerator FIN4BOK()
    {

        calmos = true;
        yield return new WaitForSeconds(1);
        Bok.SetBool("bok", false);
        chong.SetBool("Dialogue", false);
        suicidesprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        yield return new WaitForSeconds(1);
        suicideanim.SetBool("suicidactif", false);
        yield return new WaitForSeconds(3);
        suicidesprite.sortingOrder = 1;
        suicidebok.SetActive(false);
        Bokfin4.SetActive(true);
        yield return new WaitForSeconds(5);
        Enfer.SetActive(true);
        Fuite.SetActive(true);

    }

    IEnumerator FIN5BOK()
    {

        calmos = true;
        yield return new WaitForSeconds(1);
       
        chong.SetBool("Dialogue", false);
        bokmortsprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        yield return new WaitForSeconds(1);
        bokmortanim.SetBool("bokmorton", false);
        yield return new WaitForSeconds(3);
        bokmortsprite.sortingOrder = 1;
        bokmort.SetActive(false);
        Bokfin5.SetActive(true);
        yield return new WaitForSeconds(5);
        Enfer.SetActive(true);
        Fuite.SetActive(true);

    }

    IEnumerator FIN6BOK()
    {

        calmos = true;
        yield return new WaitForSeconds(1);

        chong.SetBool("Dialogue", false);
        prisonsprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        yield return new WaitForSeconds(1);
        prisonanim.SetBool("prisoon", false);
        yield return new WaitForSeconds(3);
        prisonsprite.sortingOrder = 1;
        prison.SetActive(false);
        Bokfin6.SetActive(true);
        yield return new WaitForSeconds(5);
        Enfer.SetActive(true);
        Fuite.SetActive(true);

    }

    IEnumerator FIN7BOK()
    {

        calmos = true;
        yield return new WaitForSeconds(1);

        chong.SetBool("Dialogue", false);
        brook.SetBool("brookon", false);
        vestiairesprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        yield return new WaitForSeconds(1);
        vestiaireanim.SetBool("vestiaireon", false);
        yield return new WaitForSeconds(3);
        vestiairesprite.sortingOrder = 1;
        vestiaire.SetActive(false);
        Bokfin7.SetActive(true);
        yield return new WaitForSeconds(5);
        Enfer.SetActive(true);
        Fuite.SetActive(true);

    }

    IEnumerator FIN8BOK()
    {

        calmos = true;
        yield return new WaitForSeconds(1);

        chong.SetBool("Dialogue", false);
        zyzy.SetBool("zyzydecale", false);
        zyzy.SetBool("zyzyon", false);
        dadzyzysprite.sortingOrder = 2;
        ecrannoir.SetActive(true);
        yield return new WaitForSeconds(1);
        dadzyzyanim.SetBool("daronzyzyon", false);
        yield return new WaitForSeconds(3);
        dadzyzysprite.sortingOrder = 1;
        dadzyzy.SetActive(false);
        Bokfin8.SetActive(true);
        yield return new WaitForSeconds(5);
        Enfer.SetActive(true);
        Fuite.SetActive(true);

    }






    public void DisplayNextSentence()
    {
        
            phrase += 1;
            Debug.Log(phrase);


            switch (perso)
            {
                case 1:
                    switch (Bokchoix1)
                    {
                        case 0:
                            switch (phrase)
                            {
                                case 3:

                                    Bok.SetBool("bok", true);

                                    break;

                                case 20:

                                    BokChoix1.SetActive(true);

                                    break;
                            }
                            break;

                        case 1:

                            switch (Bokchoix2)
                            {
                                case 0:

                                    switch (phrase)
                                    {
                                        case 2:
                                            StartCoroutine(parcsupermarche());

                                            break;
                                        case 8:
                                            Bok.SetBool("bok", false);
                                            break;
                                        case 9:
                                            BokChoix2.SetActive(true);
                                            break;
                                    }
                                    break;

                                case 1:

                                    switch (Bokchoix3)
                                    {
                                        case 0:
                                            switch (phrase)
                                            {
                                                case 6:
                                                    poireau.SetBool("poiron", true);
                                                    break;

                                                case 10:
                                                    supermarched.SetTrigger("bougebouge");

                                                    break;

                                                case 11:
                                                    Bok.SetBool("bok", true);
                                                    break;
                                                case 18:
                                                    poireau.SetBool("poiron", false);
                                                    break;
                                                case 25:
                                                    StartCoroutine(supersalon());
                                                    break;

                                                case 48:
                                                    BokChoix3.SetActive(true);
                                                    break;

                                            }
                                            break;

                                        case 1:
                                            switch (phrase)
                                            {
                                                case 1:
                                                    StartCoroutine(salonchambre());
                                                    break;

                                                case 6:
                                                    Bok.SetBool("bokproche", true);
                                                    break;

                                                case 8:
                                                    StartCoroutine(chambrelit());
                                                    break;

                                                case 15:
                                                    StartCoroutine(FIN1BOK());
                                                    break;
                                            }
                                            break;

                                        case 2:
                                            switch (phrase)
                                            {
                                                case 7:
                                                    StartCoroutine(salonparc());
                                                    break;

                                                case 13:
                                                    Bok.SetBool("bok", true);
                                                    break;

                                                case 48:
                                                    StartCoroutine(FIN2BOK());
                                                    break;
                                            }
                                            break;
                                    }



                                    break;



                                case 2:

                                    switch (Bokchoix4)
                                    {
                                        case 0:

                                            switch (phrase)
                                            {
                                                case 2:
                                                    mrpoireau.SetBool("mrpoiron", true);
                                                    break;
                                                case 15:
                                                    mrpoireau.SetBool("mrpoiron", false);
                                                    break;
                                                case 17:
                                                    Bok.SetBool("bok", true);
                                                    break;
                                                case 22:
                                                    Bok.SetBool("bok", false);
                                                    break;
                                                case 23:
                                                    StartCoroutine(superweeb());
                                                    break;
                                                case 31:
                                                    BokChoix4.SetActive(true);
                                                    break;
                                            }

                                            break;

                                        case 1:
                                            switch (phrase)
                                            {
                                                case 6:
                                                    StartCoroutine(weebville());
                                                    break;

                                                case 13:
                                                    KK.SetBool("kaka", true);
                                                    break;

                                                case 22:
                                                    KK.SetBool("kaka", false);
                                                    StartCoroutine(villesuicide());
                                                    break;
                                                case 37:
                                                    StartCoroutine(FIN4BOK());
                                                    break;
                                            }





                                            break;

                                        case 2:
                                            switch (phrase)
                                            {
                                                case 3:
                                                    tel.SetBool("telon", true);
                                                    break;

                                                case 16:
                                                    tel.SetBool("telon", false);
                                                    break;
                                                case 18:
                                                    StartCoroutine(weebrestau());
                                                    break;

                                                case 23:
                                                    Bok.SetBool("bok", true);
                                                    break;

                                                case 31:
                                                    Bok.SetBool("bokdeux", true);
                                                    Spagt.SetBool("Spagtonmulti", true);
                                                    break;

                                                case 40:
                                                    Bok.SetBool("bokdeux", false);
                                                    Spagt.SetBool("Spagtonmulti", false);
                                                    break;

                                                case 59:
                                                    StartCoroutine(FIN3BOK());
                                                    break;
                                            }
                                            break;
                                    }


                                    break;
                            }

                            break;

                        case 2:

                            switch (Bokchoix5)

                            {

                                case 0:

                                    switch (phrase)

                                    {
                                        case 4:
                                            Bok.SetBool("bok", false);
                                            break;

                                        case 7:
                                            StartCoroutine(parcville());
                                            break;

                                        case 12:
                                            Bok.SetBool("bokmultion", true);
                                            KK.SetBool("kkonmulti", true);
                                            break;

                                        case 29:
                                            BokChoix5.SetActive(true);
                                            break;

                                    }
                                    break;

                                case 1:
                                    switch (Bokchoix7)
                                    {
                                        case 0:
                                        switch (phrase)
                                        {
                                            case 16:
                                                StartCoroutine(villetemple());
                                                break;

                                            case 20:
                                                Bok.SetBool("bokdeux", true);
                                                zyzy.SetBool("zyzyon", true);
                                                break;
                                            case 37:
                                                Bok.SetBool("bokdeux", false);
                                                Bok.SetBool("bok", false);
                                                zyzy.SetBool("zyzydecale", true);
                                                break;

                                            case 48:
                                                BokChoix7.SetActive(true);
                                                break;
                                        }
                                            break;
                                        case 1:
                                        switch (phrase)
                                        {
                                            case 6:
                                                StartCoroutine(templecouloir());
                                                break;
                                            case 12:
                                                StartCoroutine(couloirvestiaire());
                                                break;
                                            case 14:
                                                bokcauchemar.SetBool("bokcauchemaron", true);
                                                break;
                                            case 38:
                                                bokcauchmar.SetActive(false);
                                                Brook.SetActive(true);
                                                break;
                                            case 46:
                                                StartCoroutine(FIN7BOK());
                                                break;

                                        }
                                        break;
                                        case 2:
                                        switch (phrase)
                                        {
                                            case 8:
                                                StartCoroutine(templedadzyzy());
                                                break;
                                            case 20:
                                                StartCoroutine(FIN8BOK());
                                                break;
                                        }
                                        break;
                                    }
                                    break;
                                case 2:
                                    switch (Bokchoix6)
                                    {
                                        case 0:
                                            switch (phrase)
                                        {
                                            case 17:
                                                StartCoroutine(villeterv());
                                                break;

                                            case 24:
                                                Bok.SetBool("bokdeux", true);
                                                dog.SetBool("dogon", true);
                                                break;

                                            case 36:
                                                Bok.SetBool("hagar", true);
                                                dog.SetBool("dogded", true);
                                                break;

                                            case 44:
                                                BokChoix6.SetActive(true);
                                                break;
                                        }
                                    
                                            break;
                                        case 1:
                                        switch (phrase)
                                        {
                                            case 2:
                                                dog.SetTrigger("dogvraided");
                                                dog.SetBool("dogon", false);
                                                dog.SetBool("dogded", false);
                                                break;

                                            case 14:
                                                StartCoroutine(terville());
                                                break;

                                            case 19:
                                                StartCoroutine(villeprison());
                                                break;
                                            case 40:
                                                StartCoroutine(FIN6BOK());
                                                break;
                                        }
                                            break;
                                        case 2:
                                        switch (phrase)
                                        {
                                            case 2:
                                               
                                                StartCoroutine(tervmort());
                                                break;
                                            case 26:
                                                StartCoroutine(FIN5BOK());
                                                break;
                                            
                                        }
                                            break;
                                    }
                                    break;


                            }
                            break;
                    }
                    break;




                case 2:

                    switch (phrase)
                    {
                        case 3:

                            KK.SetBool("kaka", true);

                            break;

                    }
                    break;

                case 3:

                    switch (phrase)
                    {
                        case 3:

                            Spagr.SetBool("SpagrOn", true);

                            break;

                    }
                    break;

                case 4:

                    switch (phrase)
                    {
                        case 3:

                            Spagt.SetBool("SpagtOn", true);

                            break;

                    }
                    break;

            }
            if (sentences.Count == 0)
            {
                EndDialogue();
                return;
            }


            string sentence = sentences.Dequeue();
            string name = names.Dequeue();


            nameText.text = name;
            dialogueText.text = sentence;

        
    }


    

    void EndDialogue()
    {

        
        chong.SetBool("Dialogue", false);
        Spagt.SetBool("SpagtOn", false);
        Spagr.SetBool("SpagrOn", false);
        KK.SetBool("kaka", false);
        Bok.SetBool("bok", false);
        FindObjectOfType<AudioManager>().StopPlaying("MusiqueParc");
        FindObjectOfType<AudioManager>().Play("MusiqueMenu");

        phrase = 0;
    }
}

