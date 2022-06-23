using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuilderController : MonoBehaviour
{
    [SerializeField]
    GameObject CurrentWeap;
    [SerializeField]
    GameObject CurrentAmr;
    [SerializeField]
    GameObject prefab;
    ISoilderBuilder builder;
    GameObject soilder;
    GameObject wep;
    GameObject armor;
    [SerializeField]
    GameObject AttackBtn;
    [SerializeField]
    GameObject GoldBtn;
    [SerializeField]
    GameObject LeatherBtn;
    [SerializeField]
    GameObject DragonBtn;
    [SerializeField]
    GameObject generalTxt;
    [SerializeField]
    GameObject attackText;
    bool generalMode;
    // Start is called before the first frame update
    void Start()
    {
        AttackBtn.SetActive(false);
        generalMode = false;
        GoldBtn.SetActive(false);
        LeatherBtn.SetActive(false);
        DragonBtn.SetActive(false);
        builder = new SoilderBuilder().AddLocation(0, -3).AddPrefab(prefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void IntanceSoilder(ISoilderBuilder b) {
        Soilder tempSoidler = b.build();
        soilder = Instantiate(tempSoidler.gameObject, new Vector3(tempSoidler.X, tempSoidler.Y),Quaternion.identity);
        wep = Instantiate(tempSoidler.Weapon.Prefab, new Vector3(tempSoidler.X+1.4f, tempSoidler.Y+2.2f), Quaternion.identity);
        if (generalMode)
            armor = Instantiate(tempSoidler.Armor.Prefab, new Vector3(tempSoidler.X-0.28f , tempSoidler.Y+0.3f), Quaternion.identity);

    }
    public void SwordSelected()
    {
        AttackBtn.SetActive(false);
        builder.AddWeapon("Sword");
        CurrentWeap.GetComponent<TextMeshProUGUI>().text = "Sword Selected";
    }
    public void BowSelected()
    {
        AttackBtn.SetActive(false);
        builder.AddWeapon("Bow");
        CurrentWeap.GetComponent<TextMeshProUGUI>().text = "Bow Selected";
    }
    public void GunSelected()
    {
        AttackBtn.SetActive(false);
        builder.AddWeapon("Gun");
        CurrentWeap.GetComponent<TextMeshProUGUI>().text = "Gun Selected";
    }
    public void BuildSoldier()
    {
        AttackBtn.SetActive(true);
        Destroy(soilder);
        Destroy(wep);
        Destroy(armor);
        IntanceSoilder(builder);
    }
    public void GoldArmorSelected()
    {
        AttackBtn.SetActive(false);
        builder.AddArmor("Gold");
        CurrentAmr.GetComponent<TextMeshProUGUI>().text = "Golden Armor";
    }
    public void LeatherArmorSelected()
    {
        AttackBtn.SetActive(false);
        builder.AddArmor("Leather");
        CurrentAmr.GetComponent<TextMeshProUGUI>().text = "Leather Armor";
    }
    public void DragonArmorSelected()
    {
        AttackBtn.SetActive(false);
        builder.AddArmor("Dragon");
        CurrentAmr.GetComponent<TextMeshProUGUI>().text = "Dragon Armor";
    }
    public void GeneralMode()
    {
        if (!generalMode)
        {
            CurrentWeap.GetComponent<TextMeshProUGUI>().text = "No Weapon";
            builder = new GeneralBuilder().AddLocation(0, -3).AddPrefab(prefab);
            generalTxt.GetComponent<TextMeshProUGUI>().text = "Elite Mode";
            generalMode = true;
            GoldBtn.SetActive(true);
            LeatherBtn.SetActive(true);
            DragonBtn.SetActive(true);
        }
        else
        {
            CurrentWeap.GetComponent<TextMeshProUGUI>().text = "No Weapon";
            builder = new SoilderBuilder().AddLocation(0, -3).AddPrefab(prefab);
            generalTxt.GetComponent<TextMeshProUGUI>().text = "Soldier Mode";
            generalMode = false;
            GoldBtn.SetActive(false);
            LeatherBtn.SetActive(false);
            DragonBtn.SetActive(false);
        }
        builder.AddArmor("");
        CurrentAmr.GetComponent<TextMeshProUGUI>().text = "No Armor";
    }
    public void Attack()
    {
        if (builder.GetText().Length > 0)
            attackText.GetComponent<TextMeshProUGUI>().text = builder.GetText();
        else
            attackText.GetComponent<TextMeshProUGUI>().text = "Attack";
    }
}
