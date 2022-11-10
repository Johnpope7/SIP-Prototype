using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Assembler : MonoBehaviour
{
    #region Variables
    [Header("Component Transforms")]
    Transform transformHeadpoint;
    Transform transformBodypoint;
    Transform transformLeftArmpoint;
    Transform transformRightArmpoint;
    Transform transformLegpoint;

    [Header("All Components List")]
    public List<GameObject> allPartsList;
    public GameObject[] allPartsArray;
    [Header("Head Components List")]
    public List<GameObject> headList;
    public GameObject[] headArray;
    [Header("Body Components List")]
    public List<GameObject> bodyList;
    public GameObject[] bodyArray;
    [Header("Left Arm Components List")]
    public List<GameObject> leftArmList;
    public GameObject[] leftArmArray;
    [Header("Right Arm Components List")]
    public List<GameObject> rightArmList;
    public GameObject[] rightArmArray;
    [Header("Leg Components List")]
    public List<GameObject> legList;
    public GameObject[] legArray;
    #endregion

    #region Functions
    public void AllPartsListLoader() 
    {
        allPartsArray = Resources.LoadAll<GameObject>("Pawn Pieces");
        allPartsList = allPartsArray.ToList();
    }
    public void HeadListLoader()
    {
        headArray = Resources.LoadAll<GameObject>("Heads");
        headList = headArray.ToList();
    }
    public void BodyListLoader()
    {
        bodyArray = Resources.LoadAll<GameObject>("Pawn Pieces");
        bodyList = allPartsArray.ToList();
    }
    public void LeftArmListLoader()
    {
        rightArmArray = Resources.LoadAll<GameObject>("Pawn Pieces");
        rightArmList = allPartsArray.ToList();
    }
    public void RightArmListLoader()
    {
        allPartsArray = Resources.LoadAll<GameObject>("Pawn Pieces");
        allPartsList = allPartsArray.ToList();
    }
    public void LegsListLoader()
    {
        legArray = Resources.LoadAll<GameObject>("Pawn Pieces");
        legList = allPartsArray.ToList();
    }
    /*
    public GameObject Assemble() 
    { 
     new GameObject Humanoid = Instantiate()
    }
    */
    #endregion
}
