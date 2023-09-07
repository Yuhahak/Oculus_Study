using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSkill : MonoBehaviour
{
    public GameObject player;
    public List<SkillManager> skillManager = new List<SkillManager>();
    public List<Image> skillIcon = new List<Image>();
    private float[] skillCool = { 0 };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if(skillCool[0] <= 0)
            {
                StartCoroutine(SkillTimeCheck(0));
            }
        }

        if (skillCool[0] > 0)
        {
            skillCool[0] -= Time.deltaTime;
        }
        Debug.Log(skillCool[0]);
    }

    IEnumerator SkillTimeCheck(int SkillNum)
    {
        yield return null;

        skillCool[SkillNum] = skillManager[SkillNum].cooltime;
        Vector3 spawnPosition = player.transform.position + new Vector3(0, -1, 0); // Adjust the position as needed
        Quaternion spawnRotation = Quaternion.identity; // Use the identity rotation or specify a custom rotation

        // Instantiate the skill with the specified position and rotation
        GameObject Skill_Z = Instantiate(skillManager[0].skillPrefab, spawnPosition, spawnRotation);


    }



}
