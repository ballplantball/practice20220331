# Unity C# Practice
date : 2022/03/31  
Note : 序列化(Serializable)、事件機制(delegate, events)、屬性(Properties)、OpenXR初始設定  

# 序列化(Serializable)
`_serialize.cs, 延伸學習class應用 _class.cs`  
常看到Open Source會有以下這些序列與反序列的應用，簡單統整其與Inspector的引用方式。  

[Serializable] 可序列化類別、結構，使其宣告時可以在Inspector做調整。  
ex : 可於Inspector調整_student的number/name; 練習Class / Struct 的差異與應用
```
public class Main : MonoBehaviour
{
    public student _student;
}

[Serializable]
public class student
{
    public int number;    
    public string name;
}
```
[HideInInspector] 可隱藏public宣告在Inspector顯示。  
[NonSerialized] 停用public在Inspector顯示、儲存。(個人粗淺定義)  
[SerializeField] 允許private/protected宣告顯示在Inspector顯示、儲存。  
自己的理解 : Unity Serializable 為格式化 Inspector 可儲存的方式。  

參考資料 :   
https://home.gamer.com.tw/creationDetail.php?sn=4819127  
https://answers.unity.com/questions/971872/what-does-serializable-mean-in-c-sharp.html  
https://www.itread01.com/content/1548143139.html  
https://tw.pays-tarusate.org/838312-why-should-i-use-serializefield-FLDGDB  

# Unity C#事件機制(delegate, events)
`Controller.cs, Join.cs`  

參考資料 :  
https://www.itread01.com/content/1550158208.html  
https://dev.twsiyuan.com/2017/03/c-sharp-event-in-unity.html  
UnityEvent  
https://home.gamer.com.tw/artwork.php?sn=5108437  

# 屬性(Properties)應用

參考資料 :   
https://codingnote.cc/zh-tw/p/234419/  
https://home.gamer.com.tw/creationDetail.php?sn=2642674  

# OpenXR

參考資料 : 
https://www.twblogs.net/a/5c2f525fbd9eee35b3a4ae81  
https://car.inotgo.com/2022/02/202202180714350852.html  
codegarden.cn/article/6865/  
