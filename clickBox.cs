using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;
using UnityEngine.Monetization;
using UnityEngine.Advertisements;


public class clickBox : MonoBehaviour
{
    // Start is called before the first frame update

    public ParticleSystem particle;
    public Button boxClicker;
    public float timerParticle;
    public bool timerBool;
    public double coins = 0;
    public int tickets = 0;
    public int perClick = 1;
    public float bonusTimer;
    public bool bonusBool;
    public float realbonusTimer;
    public bool realbonusBool;
    public float bonusVault;
    public float bonusInt = 100;
    public TextMeshProUGUI textCoins;
    public TextMeshProUGUI bonusX;
    public TextMeshProUGUI perclickText;
    public float priceFirstUpgrade = 1000;
    public TextMeshProUGUI firstText;
    public int levelFirstUpgrade;
    public TextMeshProUGUI textCoinsINUpgrades;
    public TextMeshProUGUI perClickInUpgrades;
    public Sprite lockedUpgradesFirst;
    public Sprite unlockedUpgradesFirst;
    public Button buyFirst;
    public Slider greenUpgrade;
    public ParticleSystem perParticle;
    public float particlePer;
    public bool particleBool;
    public TextMeshProUGUI howmuchperclick;
    public TextMeshProUGUI howmuchbonus;
    public TextMeshProUGUI secondText;
    public float priceSecondUpgrade = 10000;
    public Button buySecond;
    public int levelSecondUpgrade;
    public Slider greenUpgrade2;
    public int ticketsDuels;
    public TextMeshProUGUI ticketsDuelsText;
    public TextMeshProUGUI ticketsText;
    public TextMeshProUGUI watchAds;
    public int watchedAds = 3;
    public Button watchAdToAddBrawler;
    public Button adBrawler2;
    public Button adBrawler1;
    public Sprite unlockedChoose;
    public Sprite lockedChoose;
    public int shelly = 0;
    public int nita = 0;
    public int colt = 0;
    public int bull = 0;
    public int elprimo = 0;
    public int bea = 0;
    public int leon = 0;
    public Button chooseShelly;
    public Button chooseNita;
    public Button chooseColt;
    public Button chooseBull;
    public Button chooseElPrimo;
    public Button chooseBea;
    public Button chooseLeon;

    public Button chooseShelly2;
    public Button chooseNita2;
    public Button chooseColt2;
    public Button chooseBull2;
    public Button chooseElPrimo2;
    public Button chooseBea2;
    public Button chooseLeon2;




    public Sprite locked;
    public Sprite unlocked;
    public int selectedShelly;
    public int selectedNita;
    public int selectedColt;
    public int selectedBull;
    public int selectedElPrimo;
    public int selectedBea;
    public int selectedLeon;

    public int selectedShelly2;
    public int selectedNita2;
    public int selectedColt2;
    public int selectedBull2;
    public int selectedElPrimo2;
    public int selectedBea2;
    public int selectedLeon2;



    public Sprite sshelly;
    public Sprite snita;
    public Sprite sCOlt;
    public Sprite sbull;
    public Sprite selprimo;
    public Sprite sbea;
    public Sprite sleaon;
    public Sprite locked2;
    public Sprite unlocked2;
    public Sprite locked3;
    public Sprite unlocked3;
    public Sprite locked4;
    public Sprite unlocked4;
    public Sprite locked5;
    public Sprite unlocked5;
    public Sprite locked6;
    public Sprite unlocked6;
    public Sprite locked7;
    public Sprite unlocked7;
    public float priceTrophy = 5000000;
    public Button buyShelly;
    public Sprite greenbutton;
    public Sprite redbutton;
    public int trophyroads;
    public TextMeshProUGUI textTrophyPrice;
    public Sprite selectedShellySprite;
    public Button wheelShelly;
    public Slider hpBrawler;
    public TextMeshProUGUI hpBrawlerText;
    public Slider hpMiddleRobot;
    public TextMeshProUGUI hpMiddleRobotText;
    public Sprite plusAdBrawleresChoose;
    public int selectedNumber = 0;
    public int selectedNumber2 = 0;
    public float ticketsTimerMinutes = 29;
    public float ticketsTimerSeconds = 59;
    public bool ticketsBool;
    public TextMeshProUGUI ticketsTimerText;
    public int beatEasy;
    public int beatMiddle;
    public Image robotMiddle;
    public Sprite beated;
    public Sprite beatedEasy;
    public Sprite beatedHard;
    public Image robotHard;
    public TextMeshProUGUI textTrophyPrice2;
    public TextMeshProUGUI textTrophyPrice3;
    public TextMeshProUGUI textTrophyPrice4;
    public Button buyNita;
    public Button wheelNita;
    public Sprite fullPerClickBadge;
    public Sprite fullBonusBadge;
    public Image badgeShow;
    public Image wheelColt;
    public Sprite middleBossBeated;
    public Image robotEasy;
    public int beatHard;
    public Image wheelBull;
    public Image wheelElPrimo;
    public Image wheelBea;
    public Image wheelLeon;
    public Button buyColt;
    public Button buyBea;
    public Button buyElPrimo;
    public Button buyBull;
    public TextMeshProUGUI textTrophyPrice5;
    public TextMeshProUGUI textTrophyPrice6;
    public TextMeshProUGUI textTrophyPrice7;
    public Button buyLeon;
    public Sprite easyBossBeated;
    public Sprite hardBossBeated;
    public int levelThirdUpgrade;
    public float priceThirdUpgrades = 100000;
    public Button buyThird;
    public float randomShards;
    public float shardsLevel;
    public int shardBrawler;
    public float timerShard;
    public bool timerShardBool;
    public Animator shardAnimator;
    public Image shardWhat;
    public bool timerafterbackground;
    public float timerafterbg;
    public Image shardBackground;
    public Sprite mortisShard;
    public TextMeshProUGUI shardText;
    public int mortisLevelShard;
    public ParticleSystem shardParticle;
    public TextMeshProUGUI priceShard;
    public TextMeshProUGUI textShardUpgrade;
    public Slider greenShards;
    public Sprite mortis13;
    public Sprite mortis23;
    public Sprite mortis33;
    public Image mortisShardImage;
    public Sprite mortis03;
    public TextMeshProUGUI textShardReq;
    public Button mortisUnlock;
    public Image unlockBackground;
    public Animator mortis1;
    public Animator mortis2;
    public Animator mortis3;
    public Animator mortisText;
    public Image mortisImage1;
    public Image mortisImage2;
    public Image mortisImage3;
    public TextMeshProUGUI mortisTextUnlock;
    public float shardMortisTimer;
    public bool shardMortisBool;
    public Image mortisImageALL;
    public Sprite mortisAll;
    public int clickedUnlock = 0;
    public int taraLevelShard;
    public Sprite taraShard;
    public Image taraShardImage;
    public Sprite tara13;
    public Sprite tara23;
    public Sprite tara33;
    public int clickedUnlock2 = 0;
    public Sprite taraALL;
    public Button taraUnlock;
    public TextMeshProUGUI textReq2;
    public int rarityBrawler;
    public float priceTrophy2;
    public float priceTrophy3;
    public float priceTrophy4;
    public int brawlersAmount;
    public float perclickBonus;
    public TextMeshProUGUI perclickBonusText;
    public Animator bonusPerClick;
    public float fastClickCheck;
    public int howMuch;
    public bool checkFast;
    public int bonusBonus;
    public float timerbonusstart;
    public bool watchTimer;
    public float timerbonusend;
    public bool endTimer;
    public Sprite fullShardsBadge;
    public int epicBrawlers;
    public int legendaryBrawlers;
    public float videoTimer;
    public bool videoBool;
    public TextMeshProUGUI badgesText;
    public int badgesAmount;
    public int allClicks;
    public int reach10k;
    public int reach50k;
    public int reach1mln;
    public Sprite full10k;
    public Sprite full50k;
    public Sprite full1mln;
    public TextMeshProUGUI allClicksSettings;
    public TextMeshProUGUI timeSpentText;
    public float timeSpentSeconds;
    public int timeSpentMinutes;
    public int timeSpentHours;
    public TextMeshProUGUI volumeText;
    public Slider volumeSlider;
    public AudioSource backgroundMusic;
    public int reach2Brawlers;
    public int reach4Brawlers;
    public int reach7Brawlers;
    public Sprite full2Brawlers;
    public Sprite full4Brawlers;
    public Sprite full7Brawlers;
    public int reachAllBadges;
    


    private string store_id = "3499918";
    private string tickets_video_ad = "tickets";
    private string rewarded_video_ad = "rewardedVideo";
    private string video_ad = "video";





    void Start()
    {

        Monetization.Initialize(store_id, true);

        backgroundMusic.Play();
        taraLevelShard = 3;
        mortisImageALL.enabled = false;
        unlockBackground.enabled = false;
        mortisTextUnlock.enabled = false;
        mortisImage3.enabled = false;
        mortisImage2.enabled = false;
        mortisImage1.enabled = false;

        shardParticle.gameObject.SetActive(false);
        shardText.enabled = false;
        priceTrophy = 5000000;

        howmuchbonus.text = "max: X1.20";
        howmuchperclick.text = "+5/click";
        realbonusTimer = 0;

        shardWhat.enabled = false;
        shardBackground.enabled = false;

        particle.enableEmission = false;
        bonusTimer = 0;


        perParticle.enableEmission = false;
        endTimer = true;


    }

    // Update is called once per frame
    void Update()
    {
        if (brawlersAmount >= 2 && reach2Brawlers == 0)
        {
            reach2Brawlers = 1;
            badgesAmount += 1;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasShelly.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasNita.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasColt.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasBull.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasElPrimo.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasBea.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasLeon.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasStart.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasShowBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().backgroundBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badge2Brawlers.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlocked2Brawelrs;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badgeShow.Play("badgeShow");
            badgeShow.sprite = full2Brawlers;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().textBadgeGet.text = "Congratulations!                       You got 2 Brawlers badge!";

        }

        if (brawlersAmount >= 4 && reach4Brawlers == 0)
        {
            reach4Brawlers = 1;
            badgesAmount += 1;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasShelly.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasNita.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasColt.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasBull.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasElPrimo.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasBea.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasLeon.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasStart.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasShowBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().backgroundBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badge4Brawlers.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlocked4Brawlers;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badgeShow.Play("badgeShow");
            badgeShow.sprite = full4Brawlers;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().textBadgeGet.text = "Congratulations!                       You got 4 Brawlers badge!";

        }

        if (brawlersAmount >= 7 && reach7Brawlers == 0)
        {
            reach7Brawlers = 1;
            badgesAmount += 1;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasShelly.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasNita.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasColt.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasBull.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasElPrimo.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasBea.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasLeon.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasStart.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasShowBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().backgroundBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badge7Brawlers.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlocked7Brawlers;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badgeShow.Play("badgeShow");
            badgeShow.sprite = full7Brawlers;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().textBadgeGet.text = "Congratulations!                       You got 7 Brawlers badge!";

        }


        if (brawlersAmount >= 7 && reach7Brawlers == 1)
        {
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badge7Brawlers.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlocked7Brawlers;
        }


        if (brawlersAmount >= 4 && reach4Brawlers == 1)
        {
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badge4Brawlers.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlocked4Brawlers;
        }


        if (brawlersAmount >= 2 && reach2Brawlers == 1)
        {
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badge2Brawlers.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlocked2Brawelrs;
        }


        backgroundMusic.volume = volumeSlider.value;

        volumeText.text = (volumeSlider.value * 100).ToString("F0") + "%";

        timeSpentSeconds += Time.deltaTime;

        if (timeSpentSeconds >= 60)
        {
            timeSpentMinutes += 1;
            timeSpentSeconds = 0;
        }

        if (timeSpentMinutes >= 60)
        {
            timeSpentHours += 1;
            timeSpentMinutes = 0;
        }

        if (timeSpentSeconds < 10 && timeSpentHours == 0 && timeSpentMinutes < 10)
        {


            timeSpentText.text = "0" + timeSpentMinutes + ":0" + timeSpentSeconds.ToString("F0");
        }

        if (timeSpentSeconds < 10 && timeSpentHours == 0 && timeSpentMinutes >= 10)
        {


            timeSpentText.text = timeSpentMinutes + ":0" + timeSpentSeconds.ToString("F0");
        }


        if (timeSpentSeconds >= 10 && timeSpentHours == 0 && timeSpentMinutes < 10)
        {


            timeSpentText.text = "0" + timeSpentMinutes + ":" + timeSpentSeconds.ToString("F0");
        }

        if (timeSpentSeconds >= 10 && timeSpentHours == 0 && timeSpentMinutes >= 10)
        {


            timeSpentText.text = timeSpentMinutes + ":" + timeSpentSeconds.ToString("F0");
        }


        if (timeSpentSeconds < 10 && timeSpentHours >= 1 && timeSpentMinutes < 10)
        {


            timeSpentText.text = timeSpentHours + ":0" + timeSpentMinutes + ":0" + timeSpentSeconds.ToString("F0");
        }


        if (timeSpentSeconds < 10 && timeSpentHours >= 1 && timeSpentMinutes >= 10)
        {


            timeSpentText.text = timeSpentHours + timeSpentMinutes + ":0" + timeSpentSeconds.ToString("F0");
        }
        if (timeSpentSeconds >= 10 && timeSpentHours >= 1 && timeSpentMinutes < 10)
        {


            timeSpentText.text = timeSpentHours + ":0" + timeSpentMinutes + ":" + timeSpentSeconds.ToString("F0");
        }

        if (timeSpentSeconds >= 10 && timeSpentHours >= 1 && timeSpentMinutes >= 10)
        {


            timeSpentText.text = timeSpentHours + timeSpentMinutes + ":" + timeSpentSeconds.ToString("F0");
        }



        allClicksSettings.text = allClicks.ToString();

        if (allClicks >= 1000000 && reach1mln == 0)
        {
            reach1mln = 1;
            badgesAmount += 1;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasShowBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().backgroundBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badge1mln.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlocked1mln;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badgeShow.Play("badgeShow");
            badgeShow.sprite = full1mln;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().textBadgeGet.text = "Congratulations!                       You got 1,000,000 clicks badge!";


        }

        if (allClicks >= 1000000 && reach1mln == 1)
        {
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badge1mln.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlocked1mln;
        }

        if (allClicks >= 50000 && reach50k == 0)
        {
            reach50k = 1;
            badgesAmount += 1;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasShowBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().backgroundBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badge50k.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlocked50k;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badgeShow.Play("badgeShow");
            badgeShow.sprite = full50k;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().textBadgeGet.text = "Congratulations!                       You got 50,000 clicks badge!";


        }

        if (allClicks >= 50000 && reach50k == 1)
        {
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badge50k.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlocked50k;
        }


        if (allClicks >= 10000 && reach10k == 0)
        {
            reach10k = 1;
            badgesAmount += 1;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasShowBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().backgroundBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badge10k.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlocked10k;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badgeShow.Play("badgeShow");
            badgeShow.sprite = full10k;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().textBadgeGet.text = "Congratulations!                       You got 10,000 clicks badge!";


        }

        if (allClicks >= 10000 && reach10k == 1)
        {
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badge10k.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlocked10k;
        }


        if (levelFirstUpgrade == 10)
        {
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badgePerClick.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlockedPerClick;
        }

        if (levelSecondUpgrade == 5)
        {
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badgeBonus.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlockedBonus;
        }

        if (levelThirdUpgrade == 5)
        {
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badgeShards.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlockedShards;
        }

        badgesText.text = "Badges (" + badgesAmount + " / 12) [" + (badgesAmount * 100) / 12 + "%]";

        if (timerbonusstart == 0)
        {
            bonusX.enabled = false;

            perclickBonusText.enabled = false;
            bonusInt = 100;
        }

        if (levelSecondUpgrade == 0)
        {
            bonusBonus = 15;
        }

        if (levelSecondUpgrade == 1)
        {
            bonusBonus = 20;
        }

        if (levelSecondUpgrade == 2)
        {
            bonusBonus = 25;

        }

        if (levelSecondUpgrade == 3)
        {
            bonusBonus = 30;
        }

        if (levelSecondUpgrade == 4)
        {
            bonusBonus = 35;


        }

        if (videoBool)
        {
            videoTimer += Time.deltaTime;

            if (videoTimer >= 5)
            {
                videoBool = false;
                GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().videoBackground.enabled = false;
                GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().testVideo.enabled = false;
            }
        }

        if (endTimer)
        {
            timerbonusend += Time.deltaTime;

            if (timerbonusend >= 3)
            {
                watchTimer = false;
                timerbonusstart = 0;
                checkFast = false;
            }
        }

        if (watchTimer)
        {
            timerbonusstart += Time.deltaTime;
        }

        if (levelSecondUpgrade == 5)
        {
            bonusBonus = 50;
        }

        if (mortisLevelShard != 3)
        {

            mortisUnlock.GetComponent<Image>().enabled = false;
            textShardReq.text = "You need [" + mortisLevelShard + " / 3] shards to unlock";
        }

        if (perClick >= 0 && perClick < 100)
        {
            perclickBonusText.text = perclickBonus.ToString("F1") + " - with bonus";
        }


        if (perClick >= 100)
        {
            perclickBonusText.text = perclickBonus.ToString("F0") + " - with bonus";
        }


        perclickBonus = (perClick * bonusInt) / 100;

        perclickBonusText.color = Color.green;

        if (mortisLevelShard == 3)
        {
            textShardReq.enabled = false;
            mortisUnlock.GetComponent<Image>().enabled = true;
        }



        if (checkFast)
        {
            fastClickCheck += Time.deltaTime;

            if (fastClickCheck >= 1)
            {








                howMuch = 0;
                fastClickCheck = 0;

            }
        }

        if (levelThirdUpgrade == 0)
        {
            shardsLevel = 0.05f;
        }

        if (levelThirdUpgrade == 1)
        {
            shardsLevel = 0.10f;

        }

        if (levelThirdUpgrade == 2)
        {
            shardsLevel = 0.15f;
        }

        if (levelThirdUpgrade == 3)
        {
            shardsLevel = 0.2f;
        }
        if (priceThirdUpgrades < 1000000)
        {
            priceShard.text = (priceThirdUpgrades / 1000).ToString("F") + "K";
        }
        if (priceThirdUpgrades >= 1000000 && priceThirdUpgrades < 1000000000)
        {
            priceShard.text = (priceThirdUpgrades / 1000000).ToString("F") + "M";
        }

        if (priceThirdUpgrades >= 1000000000 && priceThirdUpgrades < 1000000000000)
        {
            priceShard.text = (priceThirdUpgrades / 1000000000).ToString("F") + "B";
        }

        if (priceThirdUpgrades >= 1000000000000)
        {
            priceShard.text = (priceThirdUpgrades / 1000000000000).ToString("F") + "T";
        }

        if (GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasStart.enabled == true)
        {
            particle.gameObject.SetActive(true);
        }


        if (GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasStart.enabled == false)
        {
            particle.gameObject.SetActive(false);
        }



        if (levelThirdUpgrade == 4)
        {
            shardsLevel = 0.25f;
        }

        if (taraLevelShard == 1)
        {
            taraShardImage.sprite = tara13;
        }

        if (taraLevelShard == 2)
        {
            taraShardImage.sprite = tara23;
        }

        if (taraLevelShard == 3 && clickedUnlock2 == 0)
        {
            taraShardImage.sprite = tara33;
        }

        if (levelThirdUpgrade == 5)
        {
            shardsLevel = 0.30f;

            priceShard.enabled = false;
        }



        if (selectedBull == 1)
        {
            chooseBull2.GetComponent<Image>().sprite = sbull;
            chooseBull.GetComponent<Image>().sprite = sbull;
        }

        if (selectedBull2 == 1)
        {
            chooseBull2.GetComponent<Image>().sprite = sbull;
            chooseBull.GetComponent<Image>().sprite = sbull;
        }

        if (selectedLeon == 1)
        {
            chooseLeon2.GetComponent<Image>().sprite = sleaon;
            chooseLeon.GetComponent<Image>().sprite = sleaon;
        }

        if (selectedLeon2 == 1)
        {
            chooseLeon2.GetComponent<Image>().sprite = sleaon;
            chooseLeon.GetComponent<Image>().sprite = sleaon;
        }

        if (selectedBea == 1)
        {
            chooseBea2.GetComponent<Image>().sprite = sbea;
            chooseBea.GetComponent<Image>().sprite = sbea;
        }

        if (selectedBea2 == 1)
        {
            chooseBea2.GetComponent<Image>().sprite = sbea;
            chooseBea.GetComponent<Image>().sprite = sbea;
        }

        if (selectedElPrimo2 == 1)
        {
            chooseElPrimo2.GetComponent<Image>().sprite = selprimo;
            chooseElPrimo.GetComponent<Image>().sprite = selprimo;
        }

        if (selectedElPrimo == 1)
        {
            chooseElPrimo2.GetComponent<Image>().sprite = selprimo;
            chooseElPrimo.GetComponent<Image>().sprite = selprimo;
        }

        if (selectedNita == 1)
        {
            chooseNita2.GetComponent<Image>().sprite = snita;
            chooseNita.GetComponent<Image>().sprite = snita;
        }

        if (selectedShelly2 == 1)
        {
            chooseShelly.GetComponent<Image>().sprite = sshelly;
            chooseShelly2.GetComponent<Image>().sprite = sshelly;
        }

        if (selectedNita2 == 1)
        {
            chooseNita2.GetComponent<Image>().sprite = snita;
            chooseNita.GetComponent<Image>().sprite = snita;
        }

        if (selectedShelly == 1)
        {
            chooseShelly.GetComponent<Image>().sprite = sshelly;
            chooseShelly2.GetComponent<Image>().sprite = sshelly;
        }



        if (timerafterbackground)
        {
            timerafterbg += Time.deltaTime;

            if (timerafterbg >= 1.5)
            {
                shardWhat.enabled = false;
            }

            if (timerafterbg >= 2)
            {
                shardAnimator.Play("none");

                timerafterbackground = false;
                timerafterbg = 0;
            }
        }

        if (timerBool)
        {
            timerParticle += Time.deltaTime;


            if (timerParticle >= 1)
            {
                timerParticle = 0;
                timerBool = false;
            }

        }

        if (selectedColt == 1)
        {
            chooseColt.GetComponent<Image>().sprite = sCOlt;
            chooseColt2.GetComponent<Image>().sprite = sCOlt;
        }

        if (selectedColt2 == 1)
        {
            chooseColt.GetComponent<Image>().sprite = sCOlt;
            chooseColt2.GetComponent<Image>().sprite = sCOlt;
        }

        if (nita == 0)
        {
            chooseNita2.GetComponent<Image>().sprite = locked2;
            chooseNita.GetComponent<Image>().sprite = locked2;
            wheelNita.GetComponent<Image>().sprite = locked2;
        }

        if (bull == 0)
        {
            chooseBull.GetComponent<Image>().sprite = locked4;
            chooseBull2.GetComponent<Image>().sprite = locked4;
            wheelBull.GetComponent<Image>().sprite = locked4;
        }

        if (elprimo == 0)
        {
            chooseElPrimo.GetComponent<Image>().sprite = locked5;
            chooseElPrimo2.GetComponent<Image>().sprite = locked5;
            wheelElPrimo.GetComponent<Image>().sprite = locked5;

        }

        if (taraLevelShard == 3)
        {

            taraUnlock.GetComponent<Image>().enabled = true;
            textReq2.enabled = false;
        }

        if (taraLevelShard < 3)
        {
            taraUnlock.GetComponent<Image>().enabled = false;
            textReq2.text = "You need [" + taraLevelShard + " / 3] shards to unlock";
        }
        if (leon == 0)
        {
            chooseLeon.GetComponent<Image>().sprite = locked7;
            chooseLeon2.GetComponent<Image>().sprite = locked7;
            wheelLeon.GetComponent<Image>().sprite = locked7;

        }

        if (bea == 0)
        {
            chooseBea.GetComponent<Image>().sprite = locked6;
            chooseBea2.GetComponent<Image>().sprite = locked6;
            wheelBea.GetComponent<Image>().sprite = locked6;
        }

        if (shelly == 0)
        {
            chooseShelly2.GetComponent<Image>().sprite = locked;
            chooseShelly.GetComponent<Image>().sprite = locked;
            wheelShelly.GetComponent<Image>().sprite = locked;
        }

        if (shardMortisBool)
        {
            shardMortisTimer += Time.deltaTime;

            if (shardMortisTimer >= 2f)
            {
                mortisImage1.enabled = false;
                mortisImage2.enabled = false;
                mortisImage3.enabled = false;

                mortisImageALL.enabled = true;
            }
        }

        if (GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasStart.enabled == true)
        {
            if (shardWhat.enabled == true)
            {


                shardWhat.enabled = true;
            }


        }

        if (GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasStart.enabled == false)
        {
            if (shardWhat.enabled == true)
            {
                shardWhat.enabled = false;
            }
        }

        if (timerParticle == 0)
        {


            particle.enableEmission = false;
        }

        if (shelly == 0)
        {
            textTrophyPrice.enabled = true;
        }

        if (nita == 0)
        {
            textTrophyPrice2.enabled = true;
        }

        if (colt == 0)
        {
            textTrophyPrice3.enabled = true;
        }
        if (leon == 1 && selectedLeon == 0 && selectedLeon2 == 0)
        {
            textTrophyPrice7.enabled = false;
            buyLeon.GetComponent<Image>().enabled = false;

            chooseLeon2.GetComponent<Image>().sprite = unlocked7;
            chooseLeon.GetComponent<Image>().sprite = unlocked7;

            wheelLeon.GetComponent<Image>().sprite = unlocked7;

        }

        if (clickedUnlock2 == 1)
        {
            taraShardImage.sprite = taraALL;
        }

        if (bea == 1 && selectedBea == 0 && selectedBea2 == 0)
        {
            textTrophyPrice6.enabled = false;
            buyBea.GetComponent<Image>().enabled = false;

            chooseBea2.GetComponent<Image>().sprite = unlocked6;
            chooseBea.GetComponent<Image>().sprite = unlocked6;

            wheelBea.GetComponent<Image>().sprite = unlocked6;

        }


        if (elprimo == 1 && selectedElPrimo == 0 && selectedElPrimo2 == 0)
        {
            textTrophyPrice5.enabled = false;
            buyElPrimo.GetComponent<Image>().enabled = false;

            chooseElPrimo2.GetComponent<Image>().sprite = unlocked5;
            chooseElPrimo.GetComponent<Image>().sprite = unlocked5;

            wheelElPrimo.GetComponent<Image>().sprite = unlocked5;

        }

        if (clickedUnlock == 1)
        {
            mortisShardImage.GetComponent<Image>().sprite = mortisAll;
        }



        if (bull == 1 && selectedBull == 0 && selectedBull2 == 0)
        {
            textTrophyPrice4.enabled = false;
            buyBull.GetComponent<Image>().enabled = false;

            chooseBull.GetComponent<Image>().sprite = unlocked4;
            chooseBull2.GetComponent<Image>().sprite = unlocked4;
            wheelBull.GetComponent<Image>().sprite = unlocked4;
        }

        if (colt == 1 && selectedColt == 0 && selectedColt2 == 0)
        {
            textTrophyPrice3.enabled = false;
            buyColt.GetComponent<Image>().enabled = false;

            chooseColt2.GetComponent<Image>().sprite = unlocked3;
            chooseColt.GetComponent<Image>().sprite = unlocked3;

            wheelColt.GetComponent<Image>().sprite = unlocked3;

        }

        if (nita == 1 && selectedNita == 0 && selectedNita2 == 0)
        {
            textTrophyPrice2.enabled = false;
            buyNita.GetComponent<Image>().enabled = false;


            chooseNita2.GetComponent<Image>().sprite = unlocked2;
            chooseNita.GetComponent<Image>().sprite = unlocked2;
            wheelNita.GetComponent<Image>().sprite = unlocked2;
        }




        if (beatEasy == 1)
        {
            robotEasy.sprite = beatedEasy;
        }

        if (beatHard == 1)
        {
            robotHard.sprite = beatedHard;
        }

        if (beatMiddle == 1)
        {
            robotMiddle.sprite = beated;
        }

        if (ticketsTimerSeconds >= 10)
        {


            ticketsTimerText.text = ticketsTimerMinutes + ":" + ticketsTimerSeconds.ToString("F0") + " to add 1";
        }

        ticketsBool = true;

        if (ticketsBool)
        {

            ticketsTimerText.enabled = true;

            ticketsTimerSeconds -= Time.deltaTime;

            if (ticketsTimerSeconds <= 0)
            {
                ticketsTimerMinutes -= 1;
                ticketsTimerSeconds = 59;
            }

            if (ticketsTimerSeconds >= 0 && ticketsTimerSeconds < 10)
            {
                ticketsTimerText.text = ticketsTimerMinutes + ":0" + ticketsTimerSeconds.ToString("F0") + " to add 1";
            }

            if (ticketsTimerMinutes < 0 && tickets != 2)
            {

                tickets += 1;

                ticketsTimerMinutes = 29;

            }

            if (ticketsTimerMinutes <= 0 && tickets == 2)
            {
                tickets = 3;
                ticketsBool = false;
                ticketsTimerText.enabled = false;
            }
        }

        if (tickets > 3)
        {
            tickets = 3;
        }

        if (tickets >= 3)
        {
            ticketsBool = false;
            ticketsTimerText.text = "MAX";



        }

        if (tickets < 3)
        {

        }

        hpMiddleRobotText.text = hpMiddleRobot.value.ToString();
        hpBrawlerText.text = hpBrawler.value.ToString();

        if (coins >= 10000 && coins < 1000000)
        {
            textCoins.text = (coins / 1000).ToString("F") + "K";
        }

        if (coins >= priceTrophy)
        {
            buyShelly.GetComponent<Image>().sprite = greenbutton;
            buyNita.GetComponent<Image>().sprite = greenbutton;
            buyColt.GetComponent<Image>().sprite = greenbutton;
            buyBull.GetComponent<Image>().sprite = greenbutton;
            buyElPrimo.GetComponent<Image>().sprite = greenbutton;
            buyBea.GetComponent<Image>().sprite = greenbutton;
            buyLeon.GetComponent<Image>().sprite = greenbutton;
        }

        if (coins < priceTrophy)
        {
            buyElPrimo.GetComponent<Image>().sprite = redbutton;
            buyBea.GetComponent<Image>().sprite = redbutton;
            buyLeon.GetComponent<Image>().sprite = redbutton;
            buyColt.GetComponent<Image>().sprite = redbutton;
            buyBull.GetComponent<Image>().sprite = redbutton;
            buyNita.GetComponent<Image>().sprite = redbutton;
            buyShelly.GetComponent<Image>().sprite = redbutton;
        }


        if (timerShardBool)
        {
            timerShard += Time.deltaTime;
        }

        if (GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasUpgrades.enabled == true)
        {
            perParticle.gameObject.SetActive(true);
        }

        if (GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasUpgrades.enabled == false)
        {
            perParticle.gameObject.SetActive(false);
        }

        if (shelly == 1 && selectedShelly == 1)
        {
            adBrawler1.GetComponent<Image>().sprite = unlocked;
        }

        if (shelly == 1 && selectedShelly2 == 1)
        {
            adBrawler2.GetComponent<Image>().sprite = unlocked;
        }

        if (nita == 1 && selectedNita == 1)
        {
            adBrawler1.GetComponent<Image>().sprite = unlocked2;
        }

        if (levelThirdUpgrade == 5)
        {
            greenShards.value = 1f;
            textShardUpgrade.text = "MAX [DROP 0.3%]";
        }

        if (levelThirdUpgrade == 0)
        {
            greenShards.value = 0;
            textShardUpgrade.text = "drop + 0.05% (now 0.05%)";
        }

        if (levelThirdUpgrade == 4)
        {
            greenShards.value = 0.8f;
            textShardUpgrade.text = "drop + 0.05% (now 0.25%)";
        }

        if (levelThirdUpgrade == 3)
        {
            greenShards.value = 0.6f;
            textShardUpgrade.text = "drop + 0.05% (now 0.20%)";
        }

        if (levelThirdUpgrade == 2)
        {
            greenShards.value = 0.4f;
            textShardUpgrade.text = "drop + 0.05% (now 0.15%)";
        }

        if (levelThirdUpgrade == 1)
        {
            greenShards.value = 0.2f;
            textShardUpgrade.text = "drop + 0.05% (now 0.10%)";
        }

        if (nita == 1 && selectedNita2 == 1)
        {
            adBrawler2.GetComponent<Image>().sprite = unlocked2;
        }

        if (colt == 1 && selectedColt == 1)
        {
            adBrawler1.GetComponent<Image>().sprite = unlocked3;
        }

        if (colt == 1 && selectedColt2 == 1)
        {
            adBrawler2.GetComponent<Image>().sprite = unlocked3;
        }

        if (bull == 1 && selectedBull == 1)
        {
            adBrawler1.GetComponent<Image>().sprite = unlocked4;
        }

        if (bull == 1 && selectedBull2 == 1)
        {
            adBrawler2.GetComponent<Image>().sprite = unlocked4;
        }

        if (elprimo == 1 && selectedElPrimo == 1)
        {
            adBrawler1.GetComponent<Image>().sprite = unlocked5;
        }

        if (elprimo == 1 && selectedElPrimo2 == 1)
        {
            adBrawler2.GetComponent<Image>().sprite = unlocked5;
        }

        if (bea == 1 && selectedBea == 1)
        {
            adBrawler1.GetComponent<Image>().sprite = unlocked6;
        }



        if (bea == 1 && selectedBea2 == 1)
        {
            adBrawler2.GetComponent<Image>().sprite = unlocked6;
        }


        if (leon == 1 && selectedLeon == 1)
        {
            adBrawler1.GetComponent<Image>().sprite = unlocked7;
        }



        if (leon == 1 && selectedLeon2 == 1)
        {
            adBrawler2.GetComponent<Image>().sprite = unlocked7;
        }

        if (shelly == 1 && selectedShelly == 0 && selectedShelly2 == 0)
        {
            buyShelly.GetComponent<Image>().enabled = false;
            textTrophyPrice.enabled = false;
            chooseShelly.GetComponent<Image>().sprite = unlocked;
            chooseShelly2.GetComponent<Image>().sprite = unlocked;
            wheelShelly.GetComponent<Image>().sprite = unlocked;

        }



        if (priceTrophy >= 1000 && priceTrophy < 1000000)
        {

            textTrophyPrice4.text = (priceTrophy / 1000).ToString("F0") + "K";
            textTrophyPrice3.text = (priceTrophy / 1000).ToString("F0") + "K";
            textTrophyPrice2.text = (priceTrophy / 1000).ToString("F0") + "K";
            textTrophyPrice.text = (priceTrophy / 1000).ToString("F0") + "K";
        }

        if (priceTrophy >= 1000000 && priceTrophy < 1000000000)
        {

            textTrophyPrice4.text = (priceTrophy / 1000000).ToString("F1") + "M";
            textTrophyPrice3.text = (priceTrophy / 1000000).ToString("F1") + "M";
            textTrophyPrice2.text = (priceTrophy / 1000000).ToString("F1") + "M";
            textTrophyPrice.text = (priceTrophy / 1000000).ToString("F1") + "M";
        }

        if (priceTrophy >= 1000000000)
        {


            textTrophyPrice4.text = (priceTrophy / 1000000000).ToString("F1") + "B";
            textTrophyPrice3.text = (priceTrophy / 1000000000).ToString("F1") + "B";
            textTrophyPrice2.text = (priceTrophy / 1000000000).ToString("F1") + "B";
            textTrophyPrice.text = (priceTrophy / 1000000000).ToString("F1") + "B";
        }

        if (priceTrophy2 >= 1000 && priceTrophy2 < 1000000)
        {
            textTrophyPrice5.text = (priceTrophy2 / 1000).ToString("F0") + "K";
        }

        if (priceTrophy2 >= 1000000 && priceTrophy2 < 1000000000)
        {
            textTrophyPrice5.text = (priceTrophy2 / 1000000).ToString("F1") + "M";
        }

        if (priceTrophy2 >= 1000000000)
        {
            textTrophyPrice5.text = (priceTrophy2 / 1000000000).ToString("F1") + "B";
        }

        if (priceTrophy3 >= 1000 && priceTrophy3 < 1000000)
        {
            textTrophyPrice6.text = (priceTrophy3 / 1000).ToString("F0") + "K";
        }

        if (priceTrophy3 >= 1000000 && priceTrophy3 < 1000000000)
        {
            textTrophyPrice6.text = (priceTrophy3 / 1000000).ToString("F1") + "M";
        }

        if (priceTrophy3 >= 1000000000)
        {
            textTrophyPrice6.text = (priceTrophy3 / 1000000000).ToString("F1") + "B";
        }

        if (priceTrophy4 >= 1000 && priceTrophy4 < 1000000)
        {
            textTrophyPrice7.text = (priceTrophy4 / 1000).ToString("F0") + "K";
        }

        if (priceTrophy4 >= 1000000 && priceTrophy4 < 1000000000)
        {
            textTrophyPrice7.text = (priceTrophy4 / 1000000).ToString("F1") + "M";
        }

        if (priceTrophy4 >= 1000000000)
        {
            textTrophyPrice7.text = (priceTrophy4 / 1000000000).ToString("F1") + "B";
        }


        if (colt == 0)
        {
            chooseColt2.GetComponent<Image>().sprite = locked3;
            chooseColt.GetComponent<Image>().sprite = locked3;
            wheelColt.GetComponent<Image>().sprite = locked3;
        }

        if (selectedNumber == 0)
        {
            adBrawler1.GetComponent<Image>().sprite = plusAdBrawleresChoose;
        }

        if (selectedNumber2 == 0)
        {
            adBrawler2.GetComponent<Image>().sprite = plusAdBrawleresChoose;
        }



        if (watchedAds == 0 && selectedNumber2 == 0 && selectedNumber == 0)
        {
            adBrawler2.GetComponent<Image>().sprite = plusAdBrawleresChoose;
        }

        if (watchedAds != 0)
        {
            adBrawler2.GetComponent<Image>().sprite = lockedChoose;
        }
        watchAds.text = watchedAds.ToString() + "ADS TO UNLOCK";
        if (watchedAds == 0)
        {
            watchAdToAddBrawler.GetComponent<Image>().enabled = false;
        }



        if (selectedNumber2 == 0 && watchedAds == 0)
        {
            adBrawler2.GetComponent<Image>().sprite = plusAdBrawleresChoose;

            if (bea == 1 && selectedBea == 0)
            {


                chooseBea2.GetComponent<Image>().sprite = unlocked6;
            }

            if (leon == 1 && selectedLeon == 0)
            {
                chooseLeon2.GetComponent<Image>().sprite = unlocked7;

            }

            if (shelly == 1 && selectedShelly == 0)
            {
                chooseShelly2.GetComponent<Image>().sprite = unlocked;
            }

            if (nita == 1 && selectedNita == 0)
            {
                chooseNita2.GetComponent<Image>().sprite = unlocked2;
            }

            if (colt == 1 && selectedColt == 0)
            {
                chooseColt2.GetComponent<Image>().sprite = unlocked3;

            }

            if (bull == 1 && selectedBull == 0)
            {
                chooseBull2.GetComponent<Image>().sprite = unlocked4;

            }

            if (elprimo == 1 && selectedElPrimo == 0)
            {
                chooseElPrimo2.GetComponent<Image>().sprite = unlocked5;
            }
        }

        if (watchedAds > 0)
        {
            watchAdToAddBrawler.GetComponent<Image>().enabled = true;
            adBrawler2.interactable = false;
        }

        if (watchedAds == 0)
        {
            watchAds.enabled = false;
            adBrawler2.interactable = true;
        }
        ticketsDuels = tickets;

        ticketsText.text = tickets.ToString();

        ticketsDuelsText.text = ticketsDuels.ToString();


        if (mortisLevelShard == 0)
        {
            mortisShardImage.GetComponent<Image>().sprite = mortis03;
        }

        if (mortisLevelShard == 1)
        {
            mortisShardImage.GetComponent<Image>().sprite = mortis13;
        }

        if (mortisLevelShard == 2)
        {
            mortisShardImage.GetComponent<Image>().sprite = mortis23;
        }

        if (mortisLevelShard == 3 && clickedUnlock == 0)
        {
            mortisShardImage.GetComponent<Image>().sprite = mortis33;
        }

        if (coins >= priceSecondUpgrade)
        {
            buySecond.GetComponent<Image>().sprite = unlockedUpgradesFirst;
        }

        if (coins < priceSecondUpgrade)
        {
            buySecond.GetComponent<Image>().sprite = lockedUpgradesFirst;
        }

        if (coins < 10000)
        {


            textCoins.text = coins.ToString("F0");
        }
        if (levelFirstUpgrade == 1)
        {
            greenUpgrade.value = 0.1f;

        }

        if (levelFirstUpgrade == 2)
        {
            greenUpgrade.value = 0.2f;
        }

        if (levelFirstUpgrade == 3)
        {
            greenUpgrade.value = 0.3f;
        }

        if (levelFirstUpgrade == 4)
        {
            greenUpgrade.value = 0.4f;
        }

        if (levelFirstUpgrade == 5)
        {
            greenUpgrade.value = 0.5f;
        }

        if (levelFirstUpgrade == 6)
        {
            greenUpgrade.value = 0.6f;
        }

        if (levelFirstUpgrade == 7)
        {
            greenUpgrade.value = 0.7f;
        }

        if (levelFirstUpgrade == 8)
        {
            greenUpgrade.value = 0.8f;
        }

        if (levelFirstUpgrade == 9)
        {
            greenUpgrade.value = 0.9f;
        }

        if (levelFirstUpgrade == 10)
        {
            howmuchperclick.text = "MAX";
            firstText.enabled = false;
            greenUpgrade.value = 1f;
            buyFirst.GetComponent<Image>().sprite = lockedUpgradesFirst;

        }

        if (levelThirdUpgrade == 5)
        {
            buyThird.GetComponent<Image>().sprite = lockedUpgradesFirst;
        }

        if (coins >= priceThirdUpgrades && levelThirdUpgrade != 5)
        {
            buyThird.GetComponent<Image>().sprite = unlockedUpgradesFirst;
        }
        if (coins < priceThirdUpgrades)
        {
            buyThird.GetComponent<Image>().sprite = lockedUpgradesFirst;
        }


        if (coins >= priceFirstUpgrade && levelFirstUpgrade != 10)
        {
            buyFirst.GetComponent<Image>().sprite = unlockedUpgradesFirst;
        }

        if (coins < priceFirstUpgrade)
        {
            buyFirst.GetComponent<Image>().sprite = lockedUpgradesFirst;
        }
        textCoinsINUpgrades.text = textCoins.text.ToString();
        perClickInUpgrades.text = perclickText.text.ToString();


        if (priceFirstUpgrade >= 1000000000)
        {
            firstText.text = (priceFirstUpgrade / 1000000000).ToString("F") + "B";
        }

        if (priceFirstUpgrade >= 1000000 && priceFirstUpgrade < 1000000000)
        {
            firstText.text = (priceFirstUpgrade / 1000000).ToString("F") + "M";
        }

        if (priceFirstUpgrade >= 1000 && priceFirstUpgrade < 1000000)
        {
            firstText.text = (priceFirstUpgrade / 1000).ToString("F") + "K";
        }
        if (priceFirstUpgrade < 1000)
        {



            firstText.text = priceFirstUpgrade.ToString();
        }

        if (priceSecondUpgrade >= 10000 && priceSecondUpgrade < 1000000)
        {
            secondText.text = (priceSecondUpgrade / 1000).ToString("F") + "K";
        }

        if (priceSecondUpgrade >= 1000000 && priceSecondUpgrade < 1000000000)
        {
            secondText.text = (priceSecondUpgrade / 1000000).ToString("F") + "M";
        }

        if (brawlersAmount > 0)
        {
            priceTrophy = (2 * 5000000 * (brawlersAmount * 2));
            priceTrophy2 = (4 * 5000000 * (brawlersAmount * 2));
            priceTrophy3 = (7 * 5000000 * (brawlersAmount * 2));
            priceTrophy4 = (10 * 5000000 * (brawlersAmount * 2));
        }

        if (brawlersAmount == 0)
        {
            priceTrophy = 5000000;
            priceTrophy2 = 20000000;
            priceTrophy3 = 35000000;
            priceTrophy4 = 50000000;
        }






        if (priceSecondUpgrade >= 1000000000)
        {
            secondText.text = (priceSecondUpgrade / 1000000000).ToString("F") + "B";
        }

        if (levelSecondUpgrade == 0)
        {
            howmuchbonus.text = "max: X1.20";
        }

        if (coins >= 1000000)
        {
            textCoins.text = (coins / 1000000).ToString("F") + "M";
        }


        if (levelSecondUpgrade == 1)
        {
            howmuchbonus.text = "max: X1.25";

            greenUpgrade2.value = 0.2f;
        }

        if (levelSecondUpgrade == 2)
        {
            howmuchbonus.text = "max: X1.30";

            greenUpgrade2.value = 0.4f;
        }

        if (levelSecondUpgrade == 3)
        {
            howmuchbonus.text = "max: X1.35";

            greenUpgrade2.value = 0.6f;
        }

        if (levelSecondUpgrade == 4)
        {
            howmuchbonus.text = "max: X1.50";

            greenUpgrade2.value = 0.8f;
        }

        if (levelSecondUpgrade == 5)
        {
            secondText.enabled = false;

            howmuchbonus.text = "MAX";

            greenUpgrade2.value = 1f;
        }

        if (levelFirstUpgrade == 0)
        {
            howmuchperclick.text = "+5/click";
        }
        if (levelFirstUpgrade == 1)
        {
            howmuchperclick.text = "+250/click";

        }

        if (coins >= 1000000000 && coins < 1000000000000)
        {
            textCoins.text = (coins / 1000000000).ToString("F") + "B";
        }

        if (coins >= 1000000000000)
        {
            textCoins.text = (coins / 1000000000000).ToString("F") + "T";
        }

        if (particleBool)
        {
            particlePer += Time.deltaTime;

            if (particlePer > 0 && particlePer < 1)
            {
                perParticle.enableEmission = true;
            }

            if (particlePer >= 1)
            {
                perParticle.enableEmission = false;
                particleBool = false;
                particlePer = 0; }
        }
        perclickText.text = perClick.ToString() + "/click";

        bonusX.text = "X" + bonusVault.ToString("F2");


        if (timerbonusstart >= 3)
        {


            if (bonusInt > 100)
            {






                bonusX.enabled = true;
                perclickBonusText.enabled = true;
                bonusPerClick.Play("play");


            }
        }

        if (bonusInt == 100)
        {
            bonusX.enabled = false;
            perclickBonusText.enabled = false;
        }



        if (bonusBool)
        {
            bonusTimer += Time.deltaTime;
        }



        if (realbonusBool)
        {
            realbonusTimer += Time.deltaTime;
        }

        bonusVault = (bonusInt / 100);






        if (levelSecondUpgrade == 0)
        {


            if (bonusInt >= 115)
            {
                bonusInt = 115;
            }
        }

        if (levelSecondUpgrade == 1)
        {
            if (bonusInt >= 120)
            {
                bonusInt = 120;
            }
        }

        if (levelSecondUpgrade == 2)
        {
            if (bonusInt >= 125)
            {
                bonusInt = 125;
            }
        }

        if (levelSecondUpgrade == 3)
        {
            if (bonusInt >= 130)
            {
                bonusInt = 130;
            }
        }

        if (levelSecondUpgrade == 4)
        {
            if (bonusInt >= 135)
            {
                bonusInt = 135;
            }
        }



        if (levelSecondUpgrade == 5)
        {
            if (bonusInt >= 150)
            {
                bonusInt = 150;
            }

            buySecond.GetComponent<Image>().sprite = lockedUpgradesFirst;
        }
    }

    public void shardBackgroundClicked()
    {
        if (timerShard >= 1.5f)
        {
            timerafterbackground = true;
            shardText.enabled = false;

            shardBackground.enabled = false;
            mortisImageALL.enabled = false;

            shardParticle.Stop();


            shardAnimator.Play("play2");

            timerShardBool = false;
            timerShard = 0;
        }
    }

    public void boxClicked()
    {
        randomShards = Random.Range(0f, 100f);

        allClicks += 1;

        timerbonusend = 0;

        if (timerbonusstart >= 3)
        {
            bonusInt += 0.25f;
        }

        watchTimer = true;

        if (timerbonusstart >= 3)
        {


            checkFast = true;
        }

        howMuch += 1;


        if (perclickBonusText.enabled == false)
        {
            bonusPerClick.Play("nothing");
        }

        if (randomShards <= shardsLevel && (taraLevelShard != 3 || mortisLevelShard != 3))
        {
            if (particle.isPlaying == true)
            {
                particle.Stop();
            }

            shardParticle.gameObject.SetActive(true);


            shardParticle.Play();
            timerShardBool = true;

            shardBrawler = Random.Range(1, 100);

            shardBackground.enabled = true;
            shardWhat.enabled = true;

            shardText.enabled = true;

            shardAnimator.Play("play");


            if (taraLevelShard != 3)
            {


                if (shardBrawler >= 50)
                {
                    if (mortisLevelShard < 3)
                    {


                        mortisLevelShard += 1;
                        shardWhat.GetComponent<Image>().sprite = mortisShard;
                        shardText.text = "Congratulations! You got [" + mortisLevelShard + "/3] shard!";
                    }
                }
            }

            if (taraLevelShard == 3)
            {

                if (shardBrawler >= 1)
                {
                    if (mortisLevelShard < 3)
                    {


                        mortisLevelShard += 1;
                        shardWhat.GetComponent<Image>().sprite = mortisShard;
                        shardText.text = "Congratulations! You got [" + mortisLevelShard + "/3] shard!";
                    }
                }
            }







            if (mortisLevelShard != 3)
            {
                if (taraLevelShard != 3)
                {




                    if (shardBrawler >= 1 && shardBrawler <= 49)
                    {

                        taraLevelShard += 1;
                        shardWhat.GetComponent<Image>().sprite = taraShard;
                        shardText.text = "Congratulations! You got [" + taraLevelShard + "/3] shard!";

                    }
                }
            }

            if (mortisLevelShard == 3)
            {

                if (shardBrawler >= 1 && shardBrawler <= 100)
                {
                    if (taraLevelShard < 3)
                    {


                        taraLevelShard += 1;
                        shardWhat.GetComponent<Image>().sprite = taraShard;
                        shardText.text = "Congratulations! You got [" + taraLevelShard + "/3] shard!";
                    }
                }
            }


        }

        if (randomShards > shardsLevel)
        {

            if (timerafterbg == 0.000f)
            {
                shardAnimator.Play("none");
                shardWhat.enabled = false;
            }




            if (levelSecondUpgrade == 0)
            {


                if (bonusInt >= 115)
                {
                    bonusInt = 115;
                }
            }

            if (levelSecondUpgrade == 1)
            {
                if (bonusInt >= 120)
                {
                    bonusInt = 120;
                }
            }

            if (levelSecondUpgrade == 2)
            {
                if (bonusInt >= 125)
                {
                    bonusInt = 125;
                }
            }

            if (levelSecondUpgrade == 3)
            {
                if (bonusInt >= 130)
                {
                    bonusInt = 130;
                }
            }

            if (levelSecondUpgrade == 4)
            {
                if (bonusInt >= 135)
                {
                    bonusInt = 135;
                }
            }


            if (levelSecondUpgrade == 5)
            {
                if (bonusInt >= 150)
                {
                    bonusInt = 150;
                }
            }

            coins += (perClick * bonusVault);


            timerBool = true;

            realbonusBool = true;
            bonusBool = true;

            bonusTimer = 0;
            if (realbonusTimer < 3)
            {


                coins += perClick;
            }

            if (timerParticle == 0)
            {


                particle.enableEmission = false;
            }

            if (timerParticle > 0)
            {

                particle.enableEmission = true;
            }
        }
    }

    public void perclickBought()
    {




        if (coins >= priceFirstUpgrade && levelFirstUpgrade >= 4 && levelFirstUpgrade == 9)
        {

            badgesAmount += 1;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasUpgrades.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasStart.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasShowBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().backgroundBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badgePerClick.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlockedPerClick;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badgeShow.Play("badgeShow");
            badgeShow.sprite = fullPerClickBadge;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().textBadgeGet.text = "Congratulations!                       You got PerClick MAX badge!";
            coins -= priceFirstUpgrade;
            priceFirstUpgrade *= Random.Range(8, 12);
            perClick += 10000;
            levelFirstUpgrade += 1;
            howmuchperclick.text = "+50000/click";
            particleBool = true;

        }


        if (coins >= priceFirstUpgrade && levelFirstUpgrade >= 4 && levelFirstUpgrade < 9)
        {
            coins -= priceFirstUpgrade;
            priceFirstUpgrade *= Random.Range(8, 12);
            perClick += 10000;
            levelFirstUpgrade += 1;
            howmuchperclick.text = "+10000/click";
            particleBool = true;

        }




        if (coins >= priceFirstUpgrade && levelFirstUpgrade == 3)
        {
            coins -= priceFirstUpgrade;
            priceFirstUpgrade *= Random.Range(8, 12);
            perClick += 10000;
            levelFirstUpgrade += 1;
            howmuchperclick.text = "+10000/click";
            particleBool = true;

        }

        if (coins >= priceFirstUpgrade && levelFirstUpgrade == 2)
        {
            coins -= priceFirstUpgrade;
            priceFirstUpgrade *= Random.Range(8, 12);
            perClick += 2000;
            levelFirstUpgrade += 1;
            howmuchperclick.text = "+10000/click";
            particleBool = true;

        }
        if (coins >= priceFirstUpgrade && levelFirstUpgrade == 1)
        {
            coins -= priceFirstUpgrade;
            priceFirstUpgrade *= Random.Range(8, 12);
            perClick += 250;
            levelFirstUpgrade += 1;
            howmuchperclick.text = "+2000/click";
            particleBool = true;
        }

        if (coins >= priceFirstUpgrade && levelFirstUpgrade == 0)
        {

            particleBool = true;


            coins -= priceFirstUpgrade;
            priceFirstUpgrade *= Random.Range(8, 12);


            levelFirstUpgrade += 1;


            perClick += 5;
            howmuchperclick.text = "+250/click";



        }

    }

    public void backgroundShardUnlockClicked()
    {

        shardMortisBool = false;
        shardMortisTimer = 0;

        unlockBackground.enabled = false;
        mortisImageALL.enabled = false;

        mortisTextUnlock.enabled = false;
    }
    public void unlockMortis()
    {
        clickedUnlock += 1;


        videoBool = true;
        shardMortisBool = true;
        mortisImage1.enabled = true;
        mortisImage2.enabled = true;
        mortisImage3.enabled = true;
        unlockBackground.enabled = true;
        mortisTextUnlock.enabled = true;

        mortis1.Play("1");
        mortis2.Play("2");
        mortis3.Play("3");
        mortisText.Play("text");
        GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().testVideo.enabled = true;
        GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().videoBackground.enabled = true;



    }




    public void unlockTara()
    {

        videoBool = true;
        clickedUnlock2 += 1;

        GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().testVideo.enabled = true;
        GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().videoBackground.enabled = true;


    }
    public void shardBought()
    {
        if (coins >= priceThirdUpgrades && levelThirdUpgrade < 4)
        {
            coins -= priceThirdUpgrades;

            levelThirdUpgrade += 1;

            priceThirdUpgrades *= Random.Range(50, 120);
        }

        if (coins >= priceThirdUpgrades && levelThirdUpgrade == 4)
        {

            badgesAmount += 1;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasUpgrades.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasStart.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasShowBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().backgroundBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badgeShards.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlockedShards;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badgeShow.Play("badgeShow");
            badgeShow.sprite = fullShardsBadge;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().textBadgeGet.text = "Congratulations!                       You got Shards MAX badge!";

            coins -= priceThirdUpgrades;

            levelThirdUpgrade += 1;

            priceThirdUpgrades *= Random.Range(50, 200);
        }
    }

    public void selectNita2()
    {
        if (nita == 1 && selectedNita == 0 && selectedNita2 == 0)
        {

            selectedNumber2 = 2;
            selectedNita2 = 1;
            chooseNita2.GetComponent<Image>().sprite = snita;


            if (selectedLeon2 == 1 && leon == 1)
            {
                selectedLeon2 = 0;
                chooseLeon2.GetComponent<Image>().sprite = unlocked7;
            }

            if (selectedBull2 == 1 && bull == 1)
            {
                selectedBull2 = 0;
                chooseBull2.GetComponent<Image>().sprite = unlocked4;
            }

            if (selectedColt2 == 1 && colt == 1)
            {
                selectedColt2 = 0;
                chooseColt2.GetComponent<Image>().sprite = unlocked3;
            }

            if (selectedElPrimo2 == 1 && elprimo == 1)
            {
                selectedElPrimo2 = 0;
                chooseElPrimo2.GetComponent<Image>().sprite = unlocked5;
            }

            if (selectedBea2 == 1 && bea == 1)
            {
                selectedBea2 = 0;
                chooseBea2.GetComponent<Image>().sprite = unlocked6;
            }



            if (selectedShelly2 == 1 && shelly == 1)
            {
                selectedShelly2 = 0;
                chooseShelly2.GetComponent<Image>().sprite = unlocked;
            }


            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose2.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;


        }
    }

    public void selectNita()
    {
        if (nita == 1 && selectedNita == 0 && selectedNita2 == 0)
        {

            selectedNumber = 2;
            selectedNita = 1;
            chooseNita.GetComponent<Image>().sprite = snita;




            if (selectedBull == 1 && bull == 1)
            {
                selectedBull = 0;
                chooseBull.GetComponent<Image>().sprite = unlocked4;
            }

            if (selectedColt == 1 && colt == 1)
            {
                selectedColt = 0;
                chooseColt.GetComponent<Image>().sprite = unlocked3;
            }

            if (selectedElPrimo == 1 && elprimo == 1)
            {
                selectedElPrimo = 0;
                chooseElPrimo.GetComponent<Image>().sprite = unlocked5;
            }

            if (selectedBea == 1 && bea == 1)
            {
                selectedBea = 0;
                chooseBea.GetComponent<Image>().sprite = unlocked6;
            }

            if (selectedLeon == 1 && leon == 1)
            {
                selectedLeon = 0;
                chooseLeon.GetComponent<Image>().sprite = unlocked7;
            }

            if (selectedShelly == 1 && shelly == 1)
            {
                selectedShelly = 0;
                chooseShelly.GetComponent<Image>().sprite = unlocked;
            }




            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose1.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;


        }

    }
    public void selectShelly2()
    {
        if (shelly == 1 && selectedShelly == 0 && selectedShelly2 == 0)
        {

            selectedNumber2 = 1;
            selectedShelly2 = 1;
            chooseShelly2.GetComponent<Image>().sprite = sshelly;


            if (selectedNita2 == 1 && nita == 1)
            {
                selectedNita2 = 0;
                chooseNita2.GetComponent<Image>().sprite = unlocked2;
            }

            if (selectedBull2 == 1 && bull == 1)
            {
                selectedBull2 = 0;
                chooseBull2.GetComponent<Image>().sprite = unlocked4;
            }

            if (selectedColt2 == 1 && colt == 1)
            {
                selectedColt2 = 0;
                chooseColt2.GetComponent<Image>().sprite = unlocked3;
            }

            if (selectedElPrimo2 == 1 && elprimo == 1)
            {
                selectedElPrimo2 = 0;
                chooseElPrimo2.GetComponent<Image>().sprite = unlocked5;
            }

            if (selectedBea2 == 1 && bea == 1)
            {
                selectedBea2 = 0;
                chooseBea2.GetComponent<Image>().sprite = unlocked6;
            }



            if (selectedLeon2 == 1 && leon == 1)
            {
                selectedLeon2 = 0;
                chooseLeon2.GetComponent<Image>().sprite = unlocked7;
            }


            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose2.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;



        }

    }
    public void selectShelly()
    {
        if (shelly == 1 && selectedShelly == 0 && selectedShelly2 == 0)
        {
            chooseShelly.GetComponent<Image>().sprite = sshelly;

            selectedNumber = 1;
            selectedShelly = 1;

            if (selectedNita == 1 && nita == 1)
            {
                selectedNita = 0;
                chooseNita.GetComponent<Image>().sprite = unlocked2;
            }

            if (selectedBull == 1 && bull == 1)
            {
                selectedBull = 0;
                chooseBull.GetComponent<Image>().sprite = unlocked4;
            }

            if (selectedColt == 1 && colt == 1)
            {
                selectedColt = 0;
                chooseColt.GetComponent<Image>().sprite = unlocked3;
            }

            if (selectedElPrimo == 1 && elprimo == 1)
            {
                selectedElPrimo = 0;
                chooseElPrimo.GetComponent<Image>().sprite = unlocked5;
            }

            if (selectedBea == 1 && bea == 1)
            {
                selectedBea = 0;
                chooseBea.GetComponent<Image>().sprite = unlocked6;
            }

            if (selectedLeon == 1 && leon == 1)
            {
                selectedLeon = 0;
                chooseLeon.GetComponent<Image>().sprite = unlocked7;
            }





            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose1.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;



        }

    }

    public void selectLeon()
    {
        if (leon == 1 && selectedLeon == 0 && selectedLeon2 == 0)
        {
            chooseLeon.GetComponent<Image>().sprite = sleaon;

            selectedNumber = 7;
            selectedLeon = 1;

            if (selectedNita == 1 && nita == 1)
            {
                selectedNita = 0;
                chooseNita.GetComponent<Image>().sprite = unlocked2;
            }



            if (selectedColt == 1 && colt == 1)
            {
                selectedColt = 0;
                chooseColt.GetComponent<Image>().sprite = unlocked3;
            }

            if (selectedBull == 1 && bull == 1)
            {
                selectedBull = 0;
                chooseBull.GetComponent<Image>().sprite = unlocked4;
            }

            if (selectedElPrimo == 1 && elprimo == 1)
            {
                selectedElPrimo = 0;
                chooseElPrimo.GetComponent<Image>().sprite = unlocked5;
            }

            if (selectedBea == 1 && bea == 1)
            {
                selectedBea = 0;
                chooseBea.GetComponent<Image>().sprite = unlocked6;
            }


            if (selectedShelly == 1 && shelly == 1)
            {
                selectedShelly = 0;
                chooseShelly.GetComponent<Image>().sprite = unlocked;
            }


            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose1.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;



        }
    }

    public void selectBea()
    {
        if (bea == 1 && selectedBea == 0 && selectedBea2 == 0)
        {
            chooseBea.GetComponent<Image>().sprite = sbea;

            selectedNumber = 6;
            selectedBea = 1;

            if (selectedNita == 1 && nita == 1)
            {
                selectedNita = 0;
                chooseNita.GetComponent<Image>().sprite = unlocked2;
            }



            if (selectedColt == 1 && colt == 1)
            {
                selectedColt = 0;
                chooseColt.GetComponent<Image>().sprite = unlocked3;
            }

            if (selectedBull == 1 && bull == 1)
            {
                selectedBull = 0;
                chooseBull.GetComponent<Image>().sprite = unlocked4;
            }

            if (selectedElPrimo == 1 && elprimo == 1)
            {
                selectedElPrimo = 0;
                chooseElPrimo.GetComponent<Image>().sprite = unlocked5;
            }

            if (selectedLeon == 1 && leon == 1)
            {
                selectedLeon = 0;
                chooseLeon.GetComponent<Image>().sprite = unlocked7;
            }

            if (selectedShelly == 1 && shelly == 1)
            {
                selectedShelly = 0;
                chooseShelly.GetComponent<Image>().sprite = unlocked;
            }


            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose1.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;



        }
    }

    public void selectElPrimo()
    {
        if (elprimo == 1 && selectedElPrimo == 0 && selectedElPrimo2 == 0)
        {
            chooseElPrimo.GetComponent<Image>().sprite = selprimo;

            selectedNumber = 5;
            selectedElPrimo = 1;

            if (selectedNita == 1 && nita == 1)
            {
                selectedNita = 0;
                chooseNita.GetComponent<Image>().sprite = unlocked2;
            }



            if (selectedColt == 1 && colt == 1)
            {
                selectedColt = 0;
                chooseColt.GetComponent<Image>().sprite = unlocked3;
            }

            if (selectedBull == 1 && bull == 1)
            {
                selectedBull = 0;
                chooseBull.GetComponent<Image>().sprite = unlocked4;
            }

            if (selectedBea == 1 && bea == 1)
            {
                selectedBea = 0;
                chooseBea.GetComponent<Image>().sprite = unlocked6;
            }

            if (selectedLeon == 1 && leon == 1)
            {
                selectedLeon = 0;
                chooseLeon.GetComponent<Image>().sprite = unlocked7;
            }

            if (selectedShelly == 1 && shelly == 1)
            {
                selectedShelly = 0;
                chooseShelly.GetComponent<Image>().sprite = unlocked;
            }


            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose1.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;



        }
    }

    public void selectLeon2()
    {
        if (leon == 1 && selectedLeon == 0 && selectedLeon2 == 0)
        {
            chooseLeon2.GetComponent<Image>().sprite = sleaon;

            selectedNumber2 = 7;
            selectedLeon2 = 1;

            if (selectedNita2 == 1 && nita == 1)
            {
                selectedNita2 = 0;
                chooseNita2.GetComponent<Image>().sprite = unlocked2;
            }

            if (selectedBull2 == 1 && bull == 1)
            {
                selectedBull2 = 0;
                chooseBull2.GetComponent<Image>().sprite = unlocked4;
            }

            if (selectedColt2 == 1 && colt == 1)
            {
                selectedColt2 = 0;
                chooseColt2.GetComponent<Image>().sprite = unlocked3;
            }

            if (selectedElPrimo2 == 1 && elprimo == 1)
            {
                selectedElPrimo2 = 0;
                chooseElPrimo2.GetComponent<Image>().sprite = unlocked5;
            }

            if (selectedBea2 == 1 && bea == 1)
            {
                selectedBea2 = 0;
                chooseBea2.GetComponent<Image>().sprite = unlocked6;
            }



            if (selectedShelly2 == 1 && shelly == 1)
            {
                selectedShelly2 = 0;
                chooseShelly2.GetComponent<Image>().sprite = unlocked;
            }


            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose2.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;




        }
    }

    public void selectBea2()
    {
        if (bea == 1 && selectedBea == 0 && selectedBea2 == 0)
        {
            chooseBea2.GetComponent<Image>().sprite = sbea;

            selectedNumber2 = 6;
            selectedBea2 = 1;
            if (selectedNita2 == 1 && nita == 1)
            {
                selectedNita2 = 0;
                chooseNita2.GetComponent<Image>().sprite = unlocked2;
            }

            if (selectedBull2 == 1 && bull == 1)
            {
                selectedBull2 = 0;
                chooseBull2.GetComponent<Image>().sprite = unlocked4;
            }

            if (selectedColt2 == 1 && colt == 1)
            {
                selectedColt2 = 0;
                chooseColt2.GetComponent<Image>().sprite = unlocked3;
            }

            if (selectedElPrimo2 == 1 && elprimo == 1)
            {
                selectedElPrimo2 = 0;
                chooseElPrimo2.GetComponent<Image>().sprite = unlocked5;
            }



            if (selectedLeon2 == 1 && leon == 1)
            {
                selectedLeon2 = 0;
                chooseLeon2.GetComponent<Image>().sprite = unlocked7;
            }

            if (selectedShelly2 == 1 && shelly == 1)
            {
                selectedShelly2 = 0;
                chooseShelly2.GetComponent<Image>().sprite = unlocked;
            }


            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose2.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;



        }

    }
    public void selectElPrimo2()
    {
        if (elprimo == 1 && selectedElPrimo == 0 && selectedElPrimo2 == 0)
        {
            chooseElPrimo2.GetComponent<Image>().sprite = selprimo;

            selectedNumber2 = 5;
            selectedElPrimo2 = 1;

            if (selectedNita2 == 1 && nita == 1)
            {
                selectedNita2 = 0;
                chooseNita2.GetComponent<Image>().sprite = unlocked2;
            }

            if (selectedBull2 == 1 && bull == 1)
            {
                selectedBull2 = 0;
                chooseBull2.GetComponent<Image>().sprite = unlocked4;
            }

            if (selectedColt2 == 1 && colt == 1)
            {
                selectedColt2 = 0;
                chooseColt2.GetComponent<Image>().sprite = unlocked3;
            }


            if (selectedBea2 == 1 && bea == 1)
            {
                selectedBea2 = 0;
                chooseBea2.GetComponent<Image>().sprite = unlocked6;
            }

            if (selectedLeon2 == 1 && leon == 1)
            {
                selectedLeon2 = 0;
                chooseLeon2.GetComponent<Image>().sprite = unlocked7;
            }

            if (selectedShelly2 == 1 && shelly == 1)
            {
                selectedShelly2 = 0;
                chooseShelly2.GetComponent<Image>().sprite = unlocked;
            }


            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose2.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;



        }
    }

    public void selectBull2()
    {
        if (bull == 1 && selectedBull == 0 && selectedBull2 == 0)
        {
            chooseBull2.GetComponent<Image>().sprite = sbull;

            selectedNumber2 = 4;
            selectedBull2 = 1;

            if (selectedNita2 == 1 && nita == 1)
            {
                selectedNita2 = 0;
                chooseNita2.GetComponent<Image>().sprite = unlocked2;
            }



            if (selectedColt2 == 1 && colt == 1)
            {
                selectedColt2 = 0;
                chooseColt2.GetComponent<Image>().sprite = unlocked3;
            }

            if (selectedElPrimo2 == 1 && elprimo == 1)
            {
                selectedElPrimo2 = 0;
                chooseElPrimo2.GetComponent<Image>().sprite = unlocked5;
            }

            if (selectedBea2 == 1 && bea == 1)
            {
                selectedBea2 = 0;
                chooseBea2.GetComponent<Image>().sprite = unlocked6;
            }

            if (selectedLeon2 == 1 && leon == 1)
            {
                selectedLeon2 = 0;
                chooseLeon2.GetComponent<Image>().sprite = unlocked7;
            }

            if (selectedShelly2 == 1 && shelly == 1)
            {
                selectedShelly2 = 0;
                chooseShelly2.GetComponent<Image>().sprite = unlocked;
            }


            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose2.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;



        }

    }
    public void selectBull()
    {
        if (bull == 1 && selectedBull == 0 && selectedBull2 == 0)
        {
            chooseBull.GetComponent<Image>().sprite = sbull;

            selectedNumber = 4;
            selectedBull = 1;

            if (selectedNita == 1 && nita == 1)
            {
                selectedNita = 0;
                chooseNita.GetComponent<Image>().sprite = unlocked2;
            }



            if (selectedColt == 1 && colt == 1)
            {
                selectedColt = 0;
                chooseColt.GetComponent<Image>().sprite = unlocked3;
            }

            if (selectedElPrimo == 1 && elprimo == 1)
            {
                selectedElPrimo = 0;
                chooseElPrimo.GetComponent<Image>().sprite = unlocked5;
            }

            if (selectedBea == 1 && bea == 1)
            {
                selectedBea = 0;
                chooseBea.GetComponent<Image>().sprite = unlocked6;
            }

            if (selectedLeon == 1 && leon == 1)
            {
                selectedLeon = 0;
                chooseLeon.GetComponent<Image>().sprite = unlocked7;
            }

            if (selectedShelly == 1 && shelly == 1)
            {
                selectedShelly = 0;
                chooseShelly.GetComponent<Image>().sprite = unlocked;
            }


            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose1.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;



        }

    }


    public void selectColt()
    {
        if (colt == 1 && selectedColt == 0 && selectedColt2 == 0)
        {
            chooseColt.GetComponent<Image>().sprite = sCOlt;

            selectedNumber = 3;
            selectedColt = 1;

            if (selectedNita == 1 && nita == 1)
            {
                selectedNita = 0;
                chooseNita.GetComponent<Image>().sprite = unlocked2;
            }

            if (selectedBull == 1 && bull == 1)
            {
                selectedBull = 0;
                chooseBull.GetComponent<Image>().sprite = unlocked4;
            }



            if (selectedElPrimo == 1 && elprimo == 1)
            {
                selectedElPrimo = 0;
                chooseElPrimo.GetComponent<Image>().sprite = unlocked5;
            }

            if (selectedBea == 1 && bea == 1)
            {
                selectedBea = 0;
                chooseBea.GetComponent<Image>().sprite = unlocked6;
            }

            if (selectedLeon == 1 && leon == 1)
            {
                selectedLeon = 0;
                chooseLeon.GetComponent<Image>().sprite = unlocked7;
            }

            if (selectedShelly == 1 && shelly == 1)
            {
                selectedShelly = 0;
                chooseShelly.GetComponent<Image>().sprite = unlocked;
            }



            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose1.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;



        }

    }

    public void selectColt2()
    {
        if (colt == 1 && selectedColt == 0 && selectedColt2 == 0)
        {
            chooseColt2.GetComponent<Image>().sprite = sCOlt;

            selectedNumber2 = 3;
            selectedColt2 = 1;
            if (selectedNita2 == 1 && nita == 1)
            {
                selectedNita2 = 0;
                chooseNita2.GetComponent<Image>().sprite = unlocked2;
            }

            if (selectedBull2 == 1 && bull == 1)
            {
                selectedBull2 = 0;
                chooseBull2.GetComponent<Image>().sprite = unlocked4;
            }




            if (selectedElPrimo2 == 1 && elprimo == 1)
            {
                selectedElPrimo2 = 0;
                chooseElPrimo2.GetComponent<Image>().sprite = unlocked5;
            }

            if (selectedBea2 == 1 && bea == 1)
            {
                selectedBea2 = 0;
                chooseBea2.GetComponent<Image>().sprite = unlocked6;
            }

            if (selectedLeon2 == 1 && leon == 1)
            {
                selectedLeon2 = 0;
                chooseLeon2.GetComponent<Image>().sprite = unlocked7;
            }

            if (selectedShelly2 == 1 && shelly == 1)
            {
                selectedShelly2 = 0;
                chooseShelly2.GetComponent<Image>().sprite = unlocked;
            }


            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose2.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;



        }

    }



    public void bonusBought()
    {
        if (coins >= priceSecondUpgrade && levelSecondUpgrade == 4)
        {
            badgesAmount += 1;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasStart.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasUpgrades.enabled = false;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasShowBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().backgroundBadge.enabled = true;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badgeBonus.sprite = GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().unlockedBonus;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().badgeShow.Play("badgeShow");
            badgeShow.sprite = fullBonusBadge;
            GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().textBadgeGet.text = "Congratulations!                       You got Bonus MAX badge!";

            coins -= priceSecondUpgrade;
            priceSecondUpgrade *= Random.Range(30, 50);
            levelSecondUpgrade += 1;



        }

        if (coins >= priceSecondUpgrade && levelSecondUpgrade == 3)
        {
            coins -= priceSecondUpgrade;
            priceSecondUpgrade *= Random.Range(30, 50);
            levelSecondUpgrade += 1;

        }

        if (coins >= priceSecondUpgrade && levelSecondUpgrade == 2)
        {
            coins -= priceSecondUpgrade;
            priceSecondUpgrade *= Random.Range(30, 50);
            levelSecondUpgrade += 1;

        }

        if (coins >= priceSecondUpgrade && levelSecondUpgrade == 1)
        {
            coins -= priceSecondUpgrade;
            priceSecondUpgrade *= Random.Range(30, 50);
            levelSecondUpgrade += 1;

        }

        if (coins >= priceSecondUpgrade && levelSecondUpgrade == 0)
        {
            coins -= priceSecondUpgrade;
            priceSecondUpgrade *= Random.Range(30, 50);
            levelSecondUpgrade += 1;
            howmuchbonus.text = "max: X1.25";
        }
    }

    public void leonBuy()
    {
        if (coins >= priceTrophy4 && leon == 0)
        {
            brawlersAmount += 1;
            legendaryBrawlers += 1;
            coins -= priceTrophy4;



            leon = 1; ;


        }
    }
    public void beaBuy()
    {
        if (coins >= priceTrophy3 && bea == 0)
        {
            brawlersAmount += 1;
            epicBrawlers += 1;
            coins -= priceTrophy3;



            bea = 1; ;


        }
    }
    public void elprimoBuy()
    {
        if (coins >= priceTrophy2 && elprimo == 0)
        {
            brawlersAmount += 1;
            rarityBrawler += 1;
            coins -= priceTrophy2;



            elprimo = 1; ;


        }
    }
    public void bullBuy()
    {
        if (coins >= priceTrophy && bull == 0)
        {
            brawlersAmount += 1;
            trophyroads += 1;
            coins -= priceTrophy;



            bull = 1; ;


        }
    }
    public void coltBuy()
    {
        if (coins >= priceTrophy && colt == 0)
        {
            brawlersAmount += 1;
            trophyroads += 1;
            coins -= priceTrophy;



            colt = 1; ;


        }
    }
    public void nitaBuy()
    {
        if (coins >= priceTrophy && nita == 0)
        {
            brawlersAmount += 1;
            trophyroads += 1;
            coins -= priceTrophy;



            nita = 1; ;


        }
    }
    public void shellyBuy()
    {
        if (coins >= priceTrophy && shelly == 0)
        {
            brawlersAmount += 1;
            trophyroads += 1;
            coins -= priceTrophy;



            shelly = 1;


        }
    }

    public void adBrawlerOneMore()
    {
        watchedAds -= 1;


    }

    public void noneClicked()
    {
        selectedShelly = 0;
        selectedNita = 0;
        selectedColt = 0;
        selectedBull = 0;
        selectedElPrimo = 0;
        selectedBea = 0;
        selectedLeon = 0;
        selectedNumber = 0;
        GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose1.enabled = false;
        GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;

    }


    public void adTickets()
    {
        if (tickets < 3)
        {


            if (Monetization.IsReady(rewarded_video_ad))
            {
                ShowAdPlacementContent ad = null;

                ad = Monetization.GetPlacementContent(rewarded_video_ad) as ShowAdPlacementContent;

                if (ad != null)
                {
                    ad.Show();
                }
            }
        }
    }
    public void none2Clicked()
    {
        selectedShelly2 = 0;
        selectedNita2 = 0;
        selectedColt2 = 0;
        selectedBull2 = 0;
        selectedElPrimo2 = 0;
        selectedBea2 = 0;
        selectedLeon2 = 0;
        GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasChoose2.enabled = false;
        GameObject.Find("UpgradesButton").GetComponent<CanvasManager>().CanvasDuels.enabled = true;
        selectedNumber2 = 0;
    }






    
 
}
