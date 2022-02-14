using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//场景
public class ScenceChange : MonoBehaviour
{
    public Animator transition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToAntique()
    {
        
        StartCoroutine(MyLoadScene(1));
    }

    public void ChangeToDetailView()
    {
        SceneManager.LoadScene("DetailView");
    }

    public void ChangeToDepartandtexture()
    {
        SceneManager.LoadScene("Departandtexture");
    }


    IEnumerator MyLoadScene(int index)
    {
        if (index == 1 && SceneManager.GetActiveScene().buildIndex == 0)
        {
            //播放动画
            transition.SetTrigger("ToA");

            //动画播放时间
            yield return new WaitForSeconds(1);

            //加载场景
            GameObject.Find("Sphere").SetActive(false);
            SceneManager.LoadScene(index);
        }
    }
}
