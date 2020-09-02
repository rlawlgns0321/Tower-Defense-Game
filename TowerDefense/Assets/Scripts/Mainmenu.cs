using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Mainmenu : MonoBehaviour {

    public string levelToLoad = "LevelManage";
    public string level_manage_play = "MainScene";
    public string Manage_Deck = "ItemManager";
    //Inventory My_inven;

    public void Play()
    {
        StartCoroutine(loadScene(levelToLoad));
        Time.timeScale = 1f;
        DataManager.CreateSaveDirectory();
    }
    
    public void Level_Manage_Play()
    {
        StageLevelModifier.Modify_With_Level();
        if (LevelSelectionToggle.toggle_group.AnyTogglesOn())
            StartCoroutine(loadScene(level_manage_play));
        //   StartCoroutine(loadScene(level_manage_play));       
           Time.timeScale = 1f;
        //replace to this when you use ItemManager.
    }

    public void Level_Manage_GoToDeck()
    {
        StageLevelModifier.Modify_With_Level();
        if (LevelSelectionToggle.toggle_group.AnyTogglesOn())
            StartCoroutine(loadScene(Manage_Deck));
        //My_inven.Initialize_Inventory();
    }

    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator loadScene(string sceneName)
    {
        AsyncOperation OP = SceneManager.LoadSceneAsync(sceneName);
        while(!OP.isDone)
        {
            yield return null;
            Debug.Log(OP.progress);
        }
        OP.allowSceneActivation = true;
    }
}
