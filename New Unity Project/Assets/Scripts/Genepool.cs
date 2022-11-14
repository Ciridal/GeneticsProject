using UnityEngine;

public class MyRandom
{
    public static int GetSeed()
    {
        var random = Random;
        return Seed;
    }

    public static float Next()
    {
        return Random.Next();
    }
    
    private static System.Random Random 
    {
        get
        {
            if(m_random == null)
            {
                var random = new System.Random();
                Seed = random.Next(1, 99999999);
 
                m_random = new System.Random(Seed);
            }

            return m_random;
        }
        set
        {
            m_random = value;
        }
    }

    public static void SetSeed(int seed)
    {
        Random = new System.Random(seed);
    }

    private static int Seed;
    private static System.Random m_random;
}

public class Genepool : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject Shape;
    public GameObject Mouth;
    public GameObject EyeLeft;
    public GameObject EyeRight;
    public float eyeScale;
    public float mouthscale;

    bool gotCustomSeed;
    bool gotGenes = false;

    public Sprite[] Eyes;
    public Sprite[] Mouths;

    SpriteRenderer sprite;

    int mutationChance;

    public int customSeed;

    void Start()
    {
        var seed = MyRandom.GetSeed();
        Debug.Log("SEED: " + seed);

        
        
        if(customSeed == 0)
        {
            Random.InitState(seed);
        }
        else
        {
            Random.InitState(customSeed);
        }

        sprite = GetComponent<SpriteRenderer>();

        if (!gotGenes)
        {
            SetGenes();
        }
            
    }

    

    public void SetGenes()
    {
     
        SetColor();
        SetMouth();
        SetEyes();

        eyeScale = Random.Range(1, 3);
        mouthscale = Random.Range(0.2f, 1);

        if (EyeLeft != null && EyeRight != null)
        {
            EyeLeft.transform.localScale *= eyeScale;
            EyeRight.transform.localScale *= eyeScale;
        }
        if(Mouth)
        {
            Mouth.transform.localScale *= mouthscale;
        }

        gotGenes = true;
    }

    void SetColor()
    {
        if(sprite != null)
            sprite.color = Random.ColorHSV(0f, 1f, 1f, 1f,  0.5f, 1f);
    }

    void SetEyes()
    {
        var eyeNum = Random.Range(0, Eyes.Length);

        EyeLeft.GetComponent<SpriteRenderer>().sprite = Eyes[eyeNum];
        EyeRight.GetComponent<SpriteRenderer>().sprite = Eyes[eyeNum];
    }

    void SetMouth()
    {
        //var mouthNum = Random.Range(0, Mouths.Length);
        //Mouth.GetComponent.<SpriteRenderer>().sprite = Mouths[mouthNum]
    }

}
