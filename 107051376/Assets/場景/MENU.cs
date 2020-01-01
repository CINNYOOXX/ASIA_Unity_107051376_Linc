using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;//導入函式庫


public class MENU : MonoBehaviour

{
    public void PlayGame()
    {
        SceneManager.LoadScene("speace");//載入遊戲場景
    }
    public void How()
    {
        SceneManager.LoadScene("howtoplay");//載入玩法說明
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        SceneManager.LoadScene("replay");//重新載入
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        SceneManager.LoadScene("Ｑuit");//結束遊戲
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        SceneManager.LoadScene("Ｍenu");//回到主選單
    }
}