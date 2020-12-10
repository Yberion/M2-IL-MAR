using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator1 : MonoBehaviour
{
    // game objet primitive
    public GameObject niveau;
    GameObject initNiveau;
    public int resolution = 10;
    public float ratioObstacles = 0.5f;
    public float hauteurMax = 1.0f;
    // X = Colonne
    // Z = Ligne
    public Vector3[,] grille;

    // Start is called before the first frame update
    void Start()
    {
        initNiveau = Instantiate(niveau);

        grille = new Vector3[(int)(niveau.transform.lossyScale.x * resolution), (int)(niveau.transform.lossyScale.z * resolution)];

        for (int i = 0; i < grille.GetLength(0); ++i)
        {
            for (int j = 0; j < grille.GetLength(1); j++)
            {
                if ((i == grille.GetLength(0) - 1 && j == 0) || (i == 0 && j == grille.GetLength(0) - 1))
                {
                    continue;
                }
                
                float x = (-(resolution / 2) + i) + 0.5f;
                float z = ((resolution / 2) - j) - 0.5f;

                grille[i, j] = new Vector3(x, 0, z);

                //GameObject c = GameObject.CreatePrimitive(PrimitiveType.Cube);
                //c.transform.position = new Vector3(x, c.transform.lossyScale.y / 2, z);

                //c.transform.parent = initNiveau.transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
