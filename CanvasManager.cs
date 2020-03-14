using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;

public class CanvasManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Canvas CanvasStart;
    public Canvas CanvasUpgrades;
    public Canvas CanvasBrawlers;
    public Canvas CanvasBrawlersRare;
    public Button trophy;
    public Button rare;
    public Button trophy2;
    public Button rare2;
    public Button trophy3;
    public Button rare3;
    public Button trophy4;
    public Button rare4;
    public Button epic;
    public Button legendary;
    public Button epic2;
    public Button legendary2;
    public Button epic3;
    public Button legendary3;
    public Button epic4;
    public Button legendary4;
    public Canvas CanvasBralersEpic;
    public Canvas CanvasBrawlersLegendary;
    public Button rightClick;
    public Button shelly;
    public Button nita;
    public Button colt;
    public Button bull;
    public Button elprimo;
    public Button bae;
    public Button leon;
    public Button leftclick;
    public Canvas CanvasDuels;
    public ParticleSystem brawlersParticle;
    public Canvas fightMiddleBoos;
    public float startBattle = 3;
    public bool startBattleBool;
    public TextMeshProUGUI starBattleText;
    public bool startFight;
    public Canvas CanvasChoose1;
    public Canvas CanvasShelly;
    public Button brawlersSelected;
    public Sprite shellyDuels;
    public float attackBrawler;
    public float attackRobot;
    public bool brawler;
    public bool robot;
    public int criticBrawler;
    public int dodgeRobot;
    public int criticRobot;
    public int dodgeBrawler;
    public Animator beat;
    public Canvas CanvasADMORE;
    public ParticleSystem admore;
    public Button nextButton;
    public TextMeshProUGUI hpafterRevive;
    public Canvas CanvasNita;
    public Sprite nitaDuels;
    public float checkEnd;
    public Image backgroundBadge;
    public Animator badgeShow;
    public Canvas CanvasShowBadge;
    public Animator transformBadge;
    public TextMeshProUGUI textBadgeGet;
    public float badgeAdded;
    public bool badgeadd;
    public Canvas CanvasBadge;
    public Image badgePerClick;
    public Sprite unlockedPerClick;
    public float timeAdMore;
    public int adMoreOn;
    public bool checkBadgeOn;
    public float checkBadgeFloat;
    public Canvas CanvasColt;
    public Canvas CanvasChoose2;
    public int chooseRobot;
    public float hpRevive;
    public bool hpReviveBool;
    public float reviveFloat;
    public Image robotImage;
    public Sprite easystats;
    public Sprite middlestats;
    public Sprite hardstats;
    public int bullets1;
    public int bullets2;
    public int bullets3;
    public int bullets4;
    public int bullets5;
    public int bullets6;
    public Animator noChoose;
    public Animator redTickets;
    public Animator noChoose2;
    public int bulletsALL;
    public bool bulletsOneBool;
    public bool bulletsOneBool2;
    public bool bulletsOneBool3;
    public bool bulletsOneBool4;
    public bool bulletsOneBool5;
    public bool bulletsOneBool6;
    public int checkBoolBullet1;
    public int checkBoolBullet2;
    public int checkBoolBullet3;
    public int checkBoolBullet4;
    public int checkBoolBullet5;
    public int checkBoolBullet6;
    public Sprite coltDuels;
    public Canvas CanvasBull;
    public Canvas CanvasElPrimo;
    public Canvas CanvasBea;
    public Canvas CanvasLeon;
    public Animator brawlerAnimator;
    public Animator bossAnimator;
    public Image badgeEasy;
    public Image badgeMedium;
    public Image badgeHard;
    public Sprite unlockedEasy;
    public Sprite unlockedMedium;
    public Sprite unlockedHard;
    public Sprite unlockedBonus;
    public Image badgeBonus;
    public Canvas CanvasShards;
    public ParticleSystem mortisParticle;
    public ParticleSystem taraParticle;
    public Image badgeShards;
    public Sprite unlockedShards;
    public Canvas CanvasSettings;
    public Sprite bullDuels;
    public Sprite elprimoDuels;
    public Sprite beaDuels;
    public Sprite leonDuels;
    public VideoPlayer testVideo;
    public RawImage videoBackground;
    public GameObject toolbar;
    public Image badge10k;
    public Image badge50k;
    public Image badge1mln;
    public Sprite unlocked10k;
    public Sprite unlocked50k;
    public Sprite unlocked1mln;
    public Image badge2Brawlers;
    public Image badge4Brawlers;
    public Image badge7Brawlers;
    public Sprite unlocked2Brawelrs;
    public Sprite unlocked4Brawlers;
    public Sprite unlocked7Brawlers;
    public Canvas CanvasAllBadges;
    public Image backgroundAllBadges;
    public int allBadges;
    public float allBadgesFloat;
    public bool allBadgesBool;
    public int instagramBonus;



    public int quality;


    void Start()
    {
        CanvasAllBadges.enabled = false;
        videoBackground.enabled = false;
        testVideo.enabled = false;
        CanvasSettings.enabled = false;
        taraParticle.gameObject.SetActive(false);
        mortisParticle.gameObject.SetActive(false);
        CanvasShards.enabled = false;
        CanvasBull.enabled = false;
        CanvasElPrimo.enabled = false;
        CanvasBea.enabled = false;
        CanvasLeon.enabled = false;
        CanvasChoose2.enabled = false;
        CanvasColt.enabled = false;
        CanvasBadge.enabled = false;
        CanvasShowBadge.enabled = false;
        CanvasNita.enabled = false;
        CanvasShelly.enabled = false;
        CanvasChoose1.enabled = false;
        fightMiddleBoos.enabled = false;
        CanvasDuels.enabled = false;
        quality = 1;
        CanvasStart.enabled = true;
        CanvasUpgrades.enabled = false;
        CanvasBrawlers.enabled = false;
        CanvasBrawlersRare.enabled = false;
        CanvasBralersEpic.enabled = false;
        CanvasBrawlersLegendary.enabled = false;
        shelly.GetComponent<Image>().enabled = true;
        nita.GetComponent<Image>().enabled = true;
        colt.GetComponent<Image>().enabled = true;
        bull.GetComponent<Image>().enabled = true;
        elprimo.GetComponent<Image>().enabled = true;
        bae.GetComponent<Image>().enabled = false;
        leon.GetComponent<Image>().enabled = false;
        rightClick.GetComponent<Image>().enabled = true;
        leftclick.GetComponent<Image>().enabled = false;
        brawlersParticle.enableEmission = false;
        CanvasADMORE.enabled = false;
        admore.gameObject.SetActive(false);
        nextButton.GetComponent<Image>().enabled = false;
        backgroundBadge.GetComponent<Image>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (allBadgesBool)
        {
            allBadgesFloat += Time.deltaTime;
        }

        if (nextButton.GetComponent<Image>().enabled == true)
        {
            starBattleText.enabled = false;
        }

        if(nextButton.GetComponent<Image>().enabled == false)
        {
            starBattleText.enabled = true;
        }

        if (badgeadd)
        {
            badgeAdded += Time.deltaTime;

            if(badgeAdded >= 2)
            {
                CanvasShowBadge.enabled = false;
                badgeadd = false;
                badgeAdded = 0;
            }
        }

        if((GameObject.Find("boxClicker").GetComponent<clickBox>().beatEasy == 1))
        {
            badgeEasy.sprite = unlockedEasy;
        }

        if ((GameObject.Find("boxClicker").GetComponent<clickBox>().beatMiddle == 1))
        {
            badgeMedium.sprite = unlockedMedium;
        }

        if ((GameObject.Find("boxClicker").GetComponent<clickBox>().beatHard == 1))
        {
            badgeHard.sprite = unlockedHard;
        }


        if (CanvasShowBadge.enabled == false)
        {
            textBadgeGet.enabled = true;
          
        }

        if (hpReviveBool)
        {
            reviveFloat += Time.deltaTime;

            if(reviveFloat > 0 && reviveFloat < 0.5)
            {
                hpRevive = (GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value * 1.5f);
            }

            if(reviveFloat >= 0.5)
            {
                hpReviveBool = false;
                reviveFloat = 0;
            }
        }


       

        if(chooseRobot == 3)
        {
            if(hpRevive > 20000)
            {
                hpRevive = 20000;
            }
        }

        if (chooseRobot == 2)
        {
            if (hpRevive > 10000)
            {
                hpRevive = 10000;
            }
        }

        if (chooseRobot == 1)
        {
            if (hpRevive > 5000)
            {
                hpRevive = 5000;
            }
        }

        hpafterRevive.text = hpRevive.ToString("F0");


        if (GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value > 0 && GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value > 0)
        {
            nextButton.GetComponent<Image>().enabled = false;
            checkEnd = 0;
       
        }

        if (GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value == 0 || GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value == 0)
        {
            checkEnd += Time.deltaTime;

            if (checkEnd >= 2)
            {


                nextButton.GetComponent<Image>().enabled = true;
            }
            brawler = false;
            robot = false;

            starBattleText.text = "END";
        }

        bulletsALL = (checkBoolBullet1 + checkBoolBullet2 + checkBoolBullet3 + checkBoolBullet4 + checkBoolBullet5 + checkBoolBullet6);

        if(GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value != 0)
        {
            adMoreOn = 0;
        }

        if(adMoreOn == 1)
        {
            timeAdMore = 0;
        }

        if(GameObject.Find("boxClicker").GetComponent<clickBox>().selectedShelly == 1)
        {
          if(bullets2 >= 25)
          {
                bulletsOneBool2 = true;
          }

          if(bullets3 >= 50)
          {
                bulletsOneBool3 = true;
          }


            if (bullets4 >= 75)
            {
                bulletsOneBool4 = true;
            }

            if (bullets5 >= 95)
            {
                bulletsOneBool5 = true;
            }

            if(bullets2 < 25)
            {
                bulletsOneBool2 = false;


            }

            if(bullets3 < 50)
            {
                bulletsOneBool3 = false;
            }

            if(bullets4 < 75)
            {
                bulletsOneBool4 = false;


            }

            if(bullets5 < 95)
            {
                bulletsOneBool5 = false;
            }

        }

        if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedColt == 1)
        {
            if (bullets2 >= 20)
            {
                bulletsOneBool2 = true;
            }

            if (bullets3 >= 40)
            {
                bulletsOneBool3 = true;
            }


            if (bullets4 >= 60)
            {
                bulletsOneBool4 = true;
            }

            if (bullets5 >= 80)
            {
                bulletsOneBool5 = true;
            }

            if(bullets6 >= 90)
            {
                bulletsOneBool6 = true;
            }

            if (bullets2 < 20)
            {
                bulletsOneBool2 = false;


            }

            if (bullets3 < 40)
            {
                bulletsOneBool3 = false;
            }

            if (bullets4 < 60)
            {
                bulletsOneBool4 = false;


            }

            if (bullets5 < 80)
            {
                bulletsOneBool5 = false;
            }

            if(bullets6 < 90)
            {
                bulletsOneBool6 = false;
            }

        }

        if (bulletsOneBool)
        {
            checkBoolBullet1 = 1;
        }

        if(bulletsOneBool == false)
        {
            checkBoolBullet1 = 0;
        }

        if(bulletsOneBool2 == false)
        {
            checkBoolBullet2 = 0;
        }

        if (bulletsOneBool3 == false)
        {
            checkBoolBullet3 = 0;
        }

        if (bulletsOneBool4 == false)
        {
            checkBoolBullet4 = 0;
        }

        if (bulletsOneBool5 == false)
        {
            checkBoolBullet5 = 0;
        }

        if (bulletsOneBool6 == false)
        {
            checkBoolBullet6 = 0;
        }

        if (bulletsOneBool2)
        {
            checkBoolBullet2 = 1;
        }

        if (bulletsOneBool3)
        {
            checkBoolBullet3 = 1;
        }

        if (bulletsOneBool4)
        {
            checkBoolBullet4 = 1;
        }

        if (bulletsOneBool5)
        {
            checkBoolBullet5 = 1;
        }

        if (bulletsOneBool6)
        {
            checkBoolBullet6 = 1;
        }

   


        if (GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value == 0)
        {
            if (adMoreOn == 0)
            {


                timeAdMore += Time.deltaTime;
            }

            if (timeAdMore < 1 && timeAdMore > 0.5)
            {

                hpReviveBool = true;
                adMoreOn = 1;
                CanvasADMORE.enabled = true;
            }

            if(timeAdMore >= 1)
            {
                timeAdMore = 0;
            }
        }

        
   

        if (startFight)
        {

            brawler = true;

        }



        if (brawler)
        {
            attackBrawler += Time.deltaTime;

            if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2)
            {
                if (attackBrawler >= 0.5f && attackBrawler < 0.6)
                {
                    beat.Play("brawler");
                    dodgeRobot = Random.Range(1, 100);

                    criticBrawler = Random.Range(1, 100);



                    if (chooseRobot == 1)
                    {
                        if (dodgeRobot <= 89)
                        {
                            brawlerAnimator.Play("hit");

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 600) * 1.25f);
                                starBattleText.text = (800 * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }
                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (800 * 1.5f);
                                starBattleText.text = (800 * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 600) * 1.25f);
                                starBattleText.text = ((800 + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 800) * 1.25f);
                                starBattleText.text = ((800 + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 720) * 1.25f);
                                starBattleText.text = ((800 + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 480) * 1.25f);
                                starBattleText.text = ((800 + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 880) * 1.25f);
                                starBattleText.text = ((800 + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 800.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= 800;

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (800 + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (800 + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (800 + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (800 + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (800 + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (800 + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (800 + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (800 + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (800 + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (800 + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (800 + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (800 + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                        }

                        if (dodgeRobot >= 90)
                        {

                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }

                    if (chooseRobot == 3)
                    {
                        if (dodgeRobot <= 74)
                        {
                            brawlerAnimator.Play("hit");

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (800 * 1.5f);
                                starBattleText.text = (800 * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 600) * 1.25f);
                                starBattleText.text = ((800 + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 600) * 1.25f);
                                starBattleText.text = ((800 + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 800) * 1.25f);
                                starBattleText.text = ((800 + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 720) * 1.25f);
                                starBattleText.text = ((800 + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 480) * 1.25f);
                                starBattleText.text = ((800 + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 880) * 1.25f);
                                starBattleText.text = ((800 + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 800.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= 800;

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 1400.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= 1400;

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 1400.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= 1400;

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 1600.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= 1600;

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 1520.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= 1520;

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 1280.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= 1280;

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 1680.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= 1680;

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                        }


                        if (dodgeRobot >= 75)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }

                    if (chooseRobot == 2)
                    {
                        if (dodgeRobot <= 84)
                        {

                            brawlerAnimator.Play("hit");
                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 600) * 1.25f);
                                starBattleText.text = (800 * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }
                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (800 * 1.5f);
                                starBattleText.text = (800 * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 600) * 1.25f);
                                starBattleText.text = ((800 + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 800) * 1.25f);
                                starBattleText.text = ((800 + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 720) * 1.25f);
                                starBattleText.text = ((800 + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 480) * 1.25f);
                                starBattleText.text = ((800 + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((800 + 880) * 1.25f);
                                starBattleText.text = ((800 + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 800.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= 800;

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (800 + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (800 + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (800 + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (800 + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (800 + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (800 + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (800 + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (800 + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (800 + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (800 + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (800 + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (800 + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                        }

                        if (dodgeRobot >= 85)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }






                    if (attackBrawler >= 0.6)
                    {
                        startFight = false;
                        brawler = false;
                        robot = true;
                        attackBrawler = 0;
                    }
                }
            }

            if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3)
            {



                if (attackBrawler >= 0.5f && attackBrawler < 0.6)
                {
                    beat.Play("brawler");
                    dodgeRobot = Random.Range(1, 100);

                    criticBrawler = Random.Range(1, 100);

                    bullets1 = Random.Range(1, 100);
                    bullets2 = Random.Range(1, 100);
                    bullets3 = Random.Range(1, 100);
                    bullets4 = Random.Range(1, 100);
                    bullets5 = Random.Range(1, 100);
                    bullets6 = Random.Range(1, 100);


                    if (chooseRobot == 1)
                    {
                        if (dodgeRobot <= 89)
                        {
                            brawlerAnimator.Play("hit");

                            if (bullets1 >= 1)
                            {
                                bulletsOneBool = true;
                            }

                            if (bullets2 >= 20)
                            {
                                bulletsOneBool2 = true;
                            }


                            if (bullets3 >= 40)
                            {
                                bulletsOneBool3 = true;
                            }


                            if (bullets4 >= 60)
                            {
                                bulletsOneBool4 = true;
                            }


                            if (bullets5 >= 80)
                            {
                                bulletsOneBool5 = true;
                            }


                            if (bullets6 >= 90)
                            {
                                bulletsOneBool6 = true;
                            }



                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 450);
                                starBattleText.text = (bulletsALL * 450).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 400) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 800) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;



                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 720) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 480) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 880) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + (bulletsALL * 300).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 300);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }



                        }

                        if (dodgeRobot >= 90)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }

                    if (chooseRobot == 2)
                    {



                        if (dodgeRobot <= 84)
                        {
                            brawlerAnimator.Play("hit");

                            if (bullets1 >= 1)
                            {
                                bulletsOneBool = true;
                            }

                            if (bullets2 >= 20)
                            {
                                bulletsOneBool2 = true;
                            }


                            if (bullets3 >= 40)
                            {
                                bulletsOneBool3 = true;
                            }


                            if (bullets4 >= 60)
                            {
                                bulletsOneBool4 = true;
                            }


                            if (bullets5 >= 80)
                            {
                                bulletsOneBool5 = true;
                            }


                            if (bullets6 >= 90)
                            {
                                bulletsOneBool6 = true;
                            }




                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 450);
                                starBattleText.text = (bulletsALL * 450).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 400) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 800) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;



                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 720) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 480) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 880) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + (bulletsALL * 300).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 300);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }



                        }

                        if (dodgeRobot >= 85)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }

                    if (chooseRobot == 3)
                    {



                        if (dodgeRobot <= 74)
                        {
                            brawlerAnimator.Play("hit");

                            if (bullets1 >= 1)
                            {
                                bulletsOneBool = true;
                            }

                            if (bullets2 >= 20)
                            {
                                bulletsOneBool2 = true;
                            }


                            if (bullets3 >= 40)
                            {
                                bulletsOneBool3 = true;
                            }


                            if (bullets4 >= 60)
                            {
                                bulletsOneBool4 = true;
                            }


                            if (bullets5 >= 80)
                            {
                                bulletsOneBool5 = true;
                            }


                            if (bullets6 >= 90)
                            {
                                bulletsOneBool6 = true;
                            }




                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 450);
                                starBattleText.text = (bulletsALL * 450).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 400) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 800) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;



                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 720) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 480) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;





                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 880) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + (bulletsALL * 300).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 300);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/6]" + ((bulletsALL * 300) + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                        }

                        if (dodgeRobot >= 75)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }

                    if (attackBrawler >= 0.6)
                    {
                        startFight = false;
                        brawler = false;
                        robot = true;
                        bulletsOneBool = false;
                        bulletsOneBool2 = false;
                        bulletsOneBool3 = false;
                        bulletsOneBool4 = false;
                        bulletsOneBool5 = false;
                        bulletsOneBool6 = false;
                        checkBoolBullet1 = 0;
                        checkBoolBullet2 = 0;
                        checkBoolBullet3 = 0;
                        checkBoolBullet4 = 0;
                        checkBoolBullet5 = 0;
                        checkBoolBullet6 = 0;
                        bullets1 = 0;
                        bullets2 = 0;
                        bullets3 = 0;
                        bullets4 = 0;
                        bullets5 = 0;
                        bullets6 = 0;
                        attackBrawler = 0;
                    }
                }

            }


            if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4)
            {



                if (attackBrawler >= 0.5f && attackBrawler < 0.6)
                {
                    beat.Play("brawler");
                    dodgeRobot = Random.Range(1, 100);

                    criticBrawler = Random.Range(1, 100);

                    bullets1 = Random.Range(1, 100);
                    bullets2 = Random.Range(1, 100);
                    bullets3 = Random.Range(1, 100);
                    bullets4 = Random.Range(1, 100);
                    bullets5 = Random.Range(1, 100);


                    if (chooseRobot == 1)
                    {
                        if (dodgeRobot <= 89)
                        {

                            brawlerAnimator.Play("hit");
                            if (bullets1 >= 1)
                            {
                                bulletsOneBool = true;
                            }

                            if (bullets2 < 25)
                            {
                                bulletsOneBool2 = false;
                            }

                            if (bullets2 >= 25)
                            {
                                bulletsOneBool2 = true;
                            }

                            if (bullets3 < 50)
                            {
                                bulletsOneBool3 = false;
                            }

                            if (bullets3 >= 50)
                            {
                                bulletsOneBool3 = true;
                            }

                            if (bullets4 < 75)
                            {
                                bulletsOneBool4 = false;
                            }

                            if (bullets4 >= 75)
                            {
                                bulletsOneBool4 = true;
                            }

                            if (bullets5 < 95)
                            {
                                bulletsOneBool5 = false;
                            }


                            if (bullets5 >= 95)
                            {
                                bulletsOneBool5 = true;
                            }





                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 400) * 1.5f);
                                starBattleText.text = ((bulletsALL * 400) * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 400) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }





                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 720) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 480) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 880) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + (bulletsALL * 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 400) + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 400) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 400) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 400) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 400) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 400) + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 400) + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 400) + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 400) + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                        }

                        if (dodgeRobot >= 90)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }

                    if (chooseRobot == 2)
                    {



                        if (dodgeRobot <= 84)
                        {
                            brawlerAnimator.Play("hit");

                            if (bullets1 >= 1)
                            {
                                bulletsOneBool = true;
                            }

                            if (bullets2 < 25)
                            {
                                bulletsOneBool2 = false;
                            }

                            if (bullets2 >= 25)
                            {
                                bulletsOneBool2 = true;
                            }

                            if (bullets3 < 50)
                            {
                                bulletsOneBool3 = false;
                            }

                            if (bullets3 >= 50)
                            {
                                bulletsOneBool3 = true;
                            }

                            if (bullets4 < 75)
                            {
                                bulletsOneBool4 = false;
                            }

                            if (bullets4 >= 75)
                            {
                                bulletsOneBool4 = true;
                            }

                            if (bullets5 < 95)
                            {
                                bulletsOneBool5 = false;
                            }


                            if (bullets5 >= 95)
                            {
                                bulletsOneBool5 = true;
                            }




                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 400) * 1.5f);
                                starBattleText.text = ((bulletsALL * 400) * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 400) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }





                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 720) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 480) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 880) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + (bulletsALL * 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 400) + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 400) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 400) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 400) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 400) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 400) + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 400) + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 400) + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 400) + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }




                        }

                        if (dodgeRobot >= 85)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }

                    if (chooseRobot == 3)
                    {



                        if (dodgeRobot <= 74)
                        {
                            brawlerAnimator.Play("hit");

                            if (bullets1 >= 1)
                            {
                                bulletsOneBool = true;
                            }

                            if (bullets2 < 25)
                            {
                                bulletsOneBool2 = false;
                            }

                            if (bullets2 >= 25)
                            {
                                bulletsOneBool2 = true;
                            }

                            if (bullets3 < 50)
                            {
                                bulletsOneBool3 = false;
                            }

                            if (bullets3 >= 50)
                            {
                                bulletsOneBool3 = true;
                            }

                            if (bullets4 < 75)
                            {
                                bulletsOneBool4 = false;
                            }

                            if (bullets4 >= 75)
                            {
                                bulletsOneBool4 = true;
                            }

                            if (bullets5 < 95)
                            {
                                bulletsOneBool5 = false;
                            }


                            if (bullets5 >= 95)
                            {
                                bulletsOneBool5 = true;
                            }




                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 400) * 1.5f);
                                starBattleText.text = ((bulletsALL * 400) * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 400) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }





                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 720) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 480) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 8 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 400) + 880) * 1.25f);
                                starBattleText.text = (((bulletsALL * 400) + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + (bulletsALL * 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 400) + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 400) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 400) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 400) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 400) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 400) + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 400) + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 9 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 400) + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 400) + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }




                        }

                        if (dodgeRobot >= 75)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }





                    if (attackBrawler >= 0.6)
                    {
                        startFight = false;
                        brawler = false;
                        robot = true;
                        bullets1 = 0;
                        bullets2 = 0;
                        bullets3 = 0;
                        bullets4 = 0;
                        bullets5 = 0;
                        bullets6 = 0;

                        checkBoolBullet1 = 0;
                        checkBoolBullet2 = 0;
                        checkBoolBullet3 = 0;
                        checkBoolBullet4 = 0;
                        checkBoolBullet5 = 0;
                        checkBoolBullet6 = 0;


                        bulletsOneBool = false;
                        bulletsOneBool2 = false;
                        bulletsOneBool3 = false;
                        bulletsOneBool4 = false;
                        bulletsOneBool5 = false;
                        bulletsOneBool6 = false;
                        attackBrawler = 0;
                    }
                }

            }




            if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6)
            {




                if (attackBrawler >= 0.5f && attackBrawler < 0.6)
                {
                    beat.Play("brawler");
                    dodgeRobot = Random.Range(1, 100);

                    criticBrawler = Random.Range(1, 100);



                    if (chooseRobot == 1)
                    {
                        if (dodgeRobot <= 89)
                        {
                            brawlerAnimator.Play("hit");

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 600) * 1.25f);
                                starBattleText.text = (960 * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }
                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 * 1.5f);
                                starBattleText.text = (960 * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 600) * 1.25f);
                                starBattleText.text = ((960 + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 800) * 1.25f);
                                starBattleText.text = ((960 + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 720) * 1.25f);
                                starBattleText.text = ((960 + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 400) * 1.25f);
                                starBattleText.text = ((960 + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 880) * 1.25f);
                                starBattleText.text = ((960 + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 960.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= 960;

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                        }

                        if (dodgeRobot >= 90)
                        {

                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }

                    if (chooseRobot == 3)
                    {
                        if (dodgeRobot <= 74)
                        {
                            brawlerAnimator.Play("hit");

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 600) * 1.25f);
                                starBattleText.text = (960 * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }
                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 * 1.5f);
                                starBattleText.text = (960 * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 600) * 1.25f);
                                starBattleText.text = ((960 + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 800) * 1.25f);
                                starBattleText.text = ((960 + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 720) * 1.25f);
                                starBattleText.text = ((960 + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 400) * 1.25f);
                                starBattleText.text = ((960 + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 880) * 1.25f);
                                starBattleText.text = ((960 + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 960.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= 960;

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                        }


                        if (dodgeRobot >= 75)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }

                    if (chooseRobot == 2)
                    {
                        if (dodgeRobot <= 84)
                        {

                            brawlerAnimator.Play("hit");
                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 600) * 1.25f);
                                starBattleText.text = (960 * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }
                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 * 1.5f);
                                starBattleText.text = (960 * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 600) * 1.25f);
                                starBattleText.text = ((960 + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 800) * 1.25f);
                                starBattleText.text = ((960 + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 720) * 1.25f);
                                starBattleText.text = ((960 + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 400) * 1.25f);
                                starBattleText.text = ((960 + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((960 + 880) * 1.25f);
                                starBattleText.text = ((960 + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 960.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= 960;

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = (960 + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (960 + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                        }

                        if (dodgeRobot >= 85)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }






                    if (attackBrawler >= 0.6)
                    {
                        startFight = false;
                        brawler = false;
                        robot = true;
                        attackBrawler = 0;
                    }
                }
            }

        



            if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5)
            {



                if (attackBrawler >= 0.5f && attackBrawler < 0.6)
                {
                    beat.Play("brawler");
                    dodgeRobot = Random.Range(1, 100);

                    criticBrawler = Random.Range(1, 100);

                    bullets1 = Random.Range(1, 100);
                    bullets2 = Random.Range(1, 100);
                    bullets3 = Random.Range(1, 100);
                    bullets4 = Random.Range(1, 100);
        


                    if (chooseRobot == 1)
                    {
                        if (dodgeRobot <= 89)
                        {

                            brawlerAnimator.Play("hit");
                            if (bullets1 >= 1)
                            {
                                bulletsOneBool = true;
                            }

                            if (bullets2 < 50)
                            {
                                bulletsOneBool2 = false;
                            }

                            if (bullets2 >= 50)
                            {
                                bulletsOneBool2 = true;
                            }

                            if (bullets3 < 70)
                            {
                                bulletsOneBool3 = false;
                            }

                            if (bullets3 >= 70)
                            {
                                bulletsOneBool3 = true;
                            }

                            if (bullets4 < 95)
                            {
                                bulletsOneBool4 = false;
                            }

                            if (bullets4 >= 95)
                            {
                                bulletsOneBool4 = true;
                            }

                       





                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) * 1.5f);
                                starBattleText.text = ((bulletsALL * 360) * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 400) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }





                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 800) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 480) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 880) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + (bulletsALL * 360).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 360);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                        }

                        if (dodgeRobot >= 90)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }

                    if (chooseRobot == 2)
                    {



                        if (dodgeRobot <= 84)
                        {
                            brawlerAnimator.Play("hit");

                            if (bullets1 >= 1)
                            {
                                bulletsOneBool = true;
                            }

                            if (bullets2 < 50)
                            {
                                bulletsOneBool2 = false;
                            }

                            if (bullets2 >= 50)
                            {
                                bulletsOneBool2 = true;
                            }

                            if (bullets3 < 75)
                            {
                                bulletsOneBool3 = false;
                            }

                            if (bullets3 >= 75)
                            {
                                bulletsOneBool3 = true;
                            }

                            if (bullets4 < 95)
                            {
                                bulletsOneBool4 = false;
                            }

                            if (bullets4 >= 95)
                            {
                                bulletsOneBool4 = true;
                            }






                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) * 1.5f);
                                starBattleText.text = ((bulletsALL * 360) * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 400) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }





                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 800) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 480) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 880) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + (bulletsALL * 360).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 360);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }




                        }

                        if (dodgeRobot >= 85)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }

                    if (chooseRobot == 3)
                    {



                        if (dodgeRobot <= 74)
                        {
                            brawlerAnimator.Play("hit");

                            if (bullets1 >= 1)
                            {
                                bulletsOneBool = true;
                            }

                            if (bullets2 < 50)
                            {
                                bulletsOneBool2 = false;
                            }

                            if (bullets2 >= 50)
                            {
                                bulletsOneBool2 = true;
                            }

                            if (bullets3 < 75)
                            {
                                bulletsOneBool3 = false;
                            }

                            if (bullets3 >= 75)
                            {
                                bulletsOneBool3 = true;
                            }

                            if (bullets4 < 95)
                            {
                                bulletsOneBool4 = false;
                            }

                            if (bullets4 >= 95)
                            {
                                bulletsOneBool4 = true;
                            }






                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) * 1.5f);
                                starBattleText.text = ((bulletsALL * 360) * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 400) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }





                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 800) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 480) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 10 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 360) + 880) * 1.25f);
                                starBattleText.text = (((bulletsALL * 360) + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + (bulletsALL * 360).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 360);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 11 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 360) + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 360) + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }



                        }

                        if (dodgeRobot >= 75)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }





                    if (attackBrawler >= 0.6)
                    {
                        startFight = false;
                        brawler = false;
                        robot = true;
                        bullets1 = 0;
                        bullets2 = 0;
                        bullets3 = 0;
                        bullets4 = 0;
                        bullets5 = 0;
                        bullets6 = 0;

                        checkBoolBullet1 = 0;
                        checkBoolBullet2 = 0;
                        checkBoolBullet3 = 0;
                        checkBoolBullet4 = 0;
                        checkBoolBullet5 = 0;
                        checkBoolBullet6 = 0;


                        bulletsOneBool = false;
                        bulletsOneBool2 = false;
                        bulletsOneBool3 = false;
                        bulletsOneBool4 = false;
                        bulletsOneBool5 = false;
                        bulletsOneBool6 = false;
                        attackBrawler = 0;
                    }
                }

            }




            if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7)
            {



                if (attackBrawler >= 0.5f && attackBrawler < 0.6)
                {
                    beat.Play("brawler");
                    dodgeRobot = Random.Range(1, 100);

                    criticBrawler = Random.Range(1, 100);

                    bullets1 = Random.Range(1, 100);
                    bullets2 = Random.Range(1, 100);
                    bullets3 = Random.Range(1, 100);
                    bullets4 = Random.Range(1, 100);



                    if (chooseRobot == 1)
                    {
                        if (dodgeRobot <= 89)
                        {

                            brawlerAnimator.Play("hit");
                            if (bullets1 >= 1)
                            {
                                bulletsOneBool = true;
                            }

                            if (bullets2 < 50)
                            {
                                bulletsOneBool2 = false;
                            }

                            if (bullets2 >= 50)
                            {
                                bulletsOneBool2 = true;
                            }

                            if (bullets3 < 70)
                            {
                                bulletsOneBool3 = false;
                            }

                            if (bullets3 >= 70)
                            {
                                bulletsOneBool3 = true;
                            }

                            if (bullets4 < 95)
                            {
                                bulletsOneBool4 = false;
                            }

                            if (bullets4 >= 95)
                            {
                                bulletsOneBool4 = true;
                            }







                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) * 1.5f);
                                starBattleText.text = ((bulletsALL * 440) * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 400) * 1.25f);
                                starBattleText.text = (((bulletsALL * 440) + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 440) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 440) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }





                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 800) * 1.25f);
                                starBattleText.text = (((bulletsALL * 440) + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 480) * 1.25f);
                                starBattleText.text = (((bulletsALL * 40) + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 720) * 1.25f);
                                starBattleText.text = (((bulletsALL * 440) + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + (bulletsALL * 440).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 440);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 33 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                        }

                        if (dodgeRobot >= 90)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }

                    if (chooseRobot == 2)
                    {



                        if (dodgeRobot <= 84)
                        {
                            brawlerAnimator.Play("hit");

                            if (bullets1 >= 1)
                            {
                                bulletsOneBool = true;
                            }

                            if (bullets2 < 50)
                            {
                                bulletsOneBool2 = false;
                            }

                            if (bullets2 >= 50)
                            {
                                bulletsOneBool2 = true;
                            }

                            if (bullets3 < 75)
                            {
                                bulletsOneBool3 = false;
                            }

                            if (bullets3 >= 75)
                            {
                                bulletsOneBool3 = true;
                            }

                            if (bullets4 < 95)
                            {
                                bulletsOneBool4 = false;
                            }

                            if (bullets4 >= 95)
                            {
                                bulletsOneBool4 = true;
                            }






                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) * 1.5f);
                                starBattleText.text = ((bulletsALL * 440) * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 400) * 1.25f);
                                starBattleText.text = (((bulletsALL * 440) + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 440) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 440) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }





                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 800) * 1.25f);
                                starBattleText.text = (((bulletsALL * 440) + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 480) * 1.25f);
                                starBattleText.text = (((bulletsALL * 40) + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 720) * 1.25f);
                                starBattleText.text = (((bulletsALL * 440) + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + (bulletsALL * 440).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 440);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 33 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }




                        }

                        if (dodgeRobot >= 85)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }

                    if (chooseRobot == 3)
                    {



                        if (dodgeRobot <= 74)
                        {
                            brawlerAnimator.Play("hit");

                            if (bullets1 >= 1)
                            {
                                bulletsOneBool = true;
                            }

                            if (bullets2 < 50)
                            {
                                bulletsOneBool2 = false;
                            }

                            if (bullets2 >= 50)
                            {
                                bulletsOneBool2 = true;
                            }

                            if (bullets3 < 75)
                            {
                                bulletsOneBool3 = false;
                            }

                            if (bullets3 >= 75)
                            {
                                bulletsOneBool3 = true;
                            }

                            if (bullets4 < 95)
                            {
                                bulletsOneBool4 = false;
                            }

                            if (bullets4 >= 95)
                            {
                                bulletsOneBool4 = true;
                            }





                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) * 1.5f);
                                starBattleText.text = ((bulletsALL * 440) * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 400) * 1.25f);
                                starBattleText.text = (((bulletsALL * 440) + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 440) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 440) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }





                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 800) * 1.25f);
                                starBattleText.text = (((bulletsALL * 440) + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 480) * 1.25f);
                                starBattleText.text = (((bulletsALL * 40) + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 440) + 720) * 1.25f);
                                starBattleText.text = (((bulletsALL * 440) + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + (bulletsALL * 440).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 440);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 33 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 440) + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 440) + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }



                        }

                        if (dodgeRobot >= 75)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }





                    if (attackBrawler >= 0.6)
                    {
                        startFight = false;
                        brawler = false;
                        robot = true;
                        bullets1 = 0;
                        bullets2 = 0;
                        bullets3 = 0;
                        bullets4 = 0;
                        bullets5 = 0;
                        bullets6 = 0;

                        checkBoolBullet1 = 0;
                        checkBoolBullet2 = 0;
                        checkBoolBullet3 = 0;
                        checkBoolBullet4 = 0;
                        checkBoolBullet5 = 0;
                        checkBoolBullet6 = 0;


                        bulletsOneBool = false;
                        bulletsOneBool2 = false;
                        bulletsOneBool3 = false;
                        bulletsOneBool4 = false;
                        bulletsOneBool5 = false;
                        bulletsOneBool6 = false;
                        attackBrawler = 0;
                    }
                }

            }


            if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1)
            {



                if (attackBrawler >= 0.5f && attackBrawler < 0.6)
                {
                    beat.Play("brawler");
                    dodgeRobot = Random.Range(1, 100);

                    criticBrawler = Random.Range(1, 100);

                    bullets1 = Random.Range(1, 100);
                    bullets2 = Random.Range(1, 100);
                    bullets3 = Random.Range(1, 100);
                    bullets4 = Random.Range(1, 100);
                    bullets5 = Random.Range(1, 100);
                   

                    if (chooseRobot == 1)
                    {
                        if (dodgeRobot <= 89)
                        {

                            brawlerAnimator.Play("hit");
                            if (bullets1 >= 1)
                            {
                                bulletsOneBool = true;
                            }

                            if(bullets2 < 25)
                            {
                                bulletsOneBool2 = false;
                            }

                            if (bullets2 >= 25)
                            {
                                bulletsOneBool2 = true;
                            }

                            if(bullets3 < 50)
                            {
                                bulletsOneBool3 = false;
                            }

                            if (bullets3 >= 50)
                            {
                                bulletsOneBool3 = true;
                            }

                            if(bullets4 < 75)
                            {
                                bulletsOneBool4 = false;
                            }

                            if (bullets4 >= 75)
                            {
                                bulletsOneBool4 = true;
                            }

                            if(bullets5 < 95)
                            {
                                bulletsOneBool5 = false;
                            }


                            if (bullets5 >= 95)
                            {
                                bulletsOneBool5 = true;
                            }


                       


                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                      
                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 450) * 1.5f);
                                starBattleText.text = ((bulletsALL * 450) * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                 
                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 400) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }



                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 800) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 720) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 480) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 300) + 880) * 1.25f);
                                starBattleText.text = (((bulletsALL * 300) + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }




                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "["+bulletsALL+"/5]"+(bulletsALL * 300).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 300);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                        }

                        if (dodgeRobot >= 90)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }

                    if (chooseRobot == 2)
                    {



                        if (dodgeRobot <= 84)
                        {
                            brawlerAnimator.Play("hit");

                            if (bullets1 >= 1)
                            {
                                bulletsOneBool = true;
                            }

                            if (bullets2 < 25)
                            {
                                bulletsOneBool2 = false;
                            }

                            if (bullets2 >= 25)
                            {
                                bulletsOneBool2 = true;
                            }

                            if (bullets3 < 50)
                            {
                                bulletsOneBool3 = false;
                            }

                            if (bullets3 >= 50)
                            {
                                bulletsOneBool3 = true;
                            }

                            if (bullets4 < 75)
                            {
                                bulletsOneBool4 = false;
                            }

                            if (bullets4 >= 75)
                            {
                                bulletsOneBool4 = true;
                            }

                            if (bullets5 < 95)
                            {
                                bulletsOneBool5 = false;
                            }


                            if (bullets5 >= 95)
                            {
                                bulletsOneBool5 = true;
                            }




                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 450) * 1.5f);
                                starBattleText.text = ((bulletsALL * 450) * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 450) + 400) * 1.25f);
                                starBattleText.text = (((bulletsALL * 450) + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 450) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 450) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 450) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 450) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 450) + 800) * 1.25f);
                                starBattleText.text = (((bulletsALL * 450) + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 450) + 720) * 1.25f);
                                starBattleText.text = (((bulletsALL * 450) + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 450) + 480) * 1.25f);
                                starBattleText.text = (((bulletsALL * 450) + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 450) + 880) * 1.25f);
                                starBattleText.text = (((bulletsALL * 450) + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + (bulletsALL * 300).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 300);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }



                        }

                        if (dodgeRobot >= 85)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }

                    if (chooseRobot == 3)
                    {



                        if (dodgeRobot <= 74)
                        {
                            brawlerAnimator.Play("hit");

                            if (bullets1 >= 1)
                            {
                                bulletsOneBool = true;
                            }

                            if (bullets2 < 25)
                            {
                                bulletsOneBool2 = false;
                            }

                            if (bullets2 >= 25)
                            {
                                bulletsOneBool2 = true;
                            }

                            if (bullets3 < 50)
                            {
                                bulletsOneBool3 = false;
                            }

                            if (bullets3 >= 50)
                            {
                                bulletsOneBool3 = true;
                            }

                            if (bullets4 < 75)
                            {
                                bulletsOneBool4 = false;
                            }

                            if (bullets4 >= 75)
                            {
                                bulletsOneBool4 = true;
                            }

                            if (bullets5 < 95)
                            {
                                bulletsOneBool5 = false;
                            }


                            if (bullets5 >= 95)
                            {
                                bulletsOneBool5 = true;
                            }




                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 450) * 1.5f);
                                starBattleText.text = ((bulletsALL * 450) * 1.5f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 450) + 400) * 1.25f);
                                starBattleText.text = (((bulletsALL * 450) + 400) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 450) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 450) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 450) + 600) * 1.25f);
                                starBattleText.text = (((bulletsALL * 450) + 600) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 450) + 800) * 1.25f);
                                starBattleText.text = (((bulletsALL * 450) + 800) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 450) + 720) * 1.25f);
                                starBattleText.text = (((bulletsALL * 450) + 720) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 450) + 480) * 1.25f);
                                starBattleText.text = (((bulletsALL * 450) + 480) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }

                            if (criticBrawler >= 0 && criticBrawler <= 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {

                                starBattleText.fontSize = 240;
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (((bulletsALL * 450) + 880) * 1.25f);
                                starBattleText.text = (((bulletsALL * 450) + 880) * 1.25f).ToString() + "CRITIC!";

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;


                            }


                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + (bulletsALL * 300).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= (bulletsALL * 300);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 400).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 400);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 600).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 600);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 800).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 800);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 720).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 720);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }

                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 480).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 480);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }


                            if (criticBrawler >= 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = "[" + bulletsALL + "/5]" + ((bulletsALL * 300) + 880).ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value -= ((bulletsALL * 300) + 880);

                                startFight = false;
                                brawler = false;
                                robot = true;
                                attackBrawler = 0;

                            }



                        }

                        if (dodgeRobot >= 75)
                        {
                            bossAnimator.Play("dodge2");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Robot Dodge!";


                            startFight = false;
                            brawler = false;
                            robot = true;
                            attackBrawler = 0;
                        }
                    }





                    if (attackBrawler >= 0.6)
                    {
                        startFight = false;
                        brawler = false;
                        robot = true;
                        bullets1 = 0;
                        bullets2 = 0;
                        bullets3 = 0;
                        bullets4 = 0;
                        bullets5 = 0;
                        bullets6 = 0;

                        checkBoolBullet1 = 0;
                        checkBoolBullet2 = 0;
                        checkBoolBullet3 = 0;
                        checkBoolBullet4 = 0;
                        checkBoolBullet5 = 0;
                        checkBoolBullet6 = 0;


                        bulletsOneBool = false;
                        bulletsOneBool2 = false;
                        bulletsOneBool3 = false;
                        bulletsOneBool4 = false;
                        bulletsOneBool5 = false;
                        bulletsOneBool6 = false;
                        attackBrawler = 0;
                    }
                }
            
            }
        }

       


        if (checkBadgeOn)
        {
            checkBadgeFloat += Time.deltaTime;

            if(checkBadgeFloat >= 3)
            {
                badgeShow.Play("off");
                transformBadge.Play("off");

            }

            if(checkBadgeFloat >= 3.2)
            {
                checkBadgeOn = false;
                checkBadgeFloat = 0;
            }
        }

        if (robot)
        {
            attackRobot += Time.deltaTime;


            if (attackRobot >= 0.5f && attackRobot < 0.6)
            {
                beat.Play("robot");
                dodgeBrawler = Random.Range(1, 100);

                criticRobot = Random.Range(1, 100);

                if (chooseRobot == 3)
                {

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedLeon == 1)
                    {
                        if (dodgeBrawler >= 80)
                        {
                            brawlerAnimator.Play("dodge");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Brawler Dodge!";


                            brawler = true;
                            robot = false;
                            attackRobot = 0;
                        }

                        if (dodgeBrawler <= 79)
                        {
                            bossAnimator.Play("hit2");

                            if (criticRobot >= 0 && criticRobot <= 50)
                            {

                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= (800 * 1.5f);
                                starBattleText.fontSize = 240;
                                starBattleText.text = (800 * 1.5f).ToString() + "CRITIC!";


                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }

                            if (criticRobot >= 51)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 800.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= 800;
                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }

                        }
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedBull == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedElPrimo == 1)
                    {
                        if (dodgeBrawler >= 85)
                        {
                            brawlerAnimator.Play("dodge");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Brawler Dodge!";


                            brawler = true;
                            robot = false;
                            attackRobot = 0;
                        }

                        if (dodgeBrawler <= 84)
                        {
                            bossAnimator.Play("hit2");

                            if (criticRobot >= 0 && criticRobot <= 50)
                            {

                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= (800 * 1.5f);
                                starBattleText.fontSize = 240;
                                starBattleText.text = (800 * 1.5f).ToString() + "CRITIC!";


                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }

                            if (criticRobot >= 51)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 800.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= 800;
                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }

                        }
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedShelly == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNita == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedColt == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedBea == 1)
                    {


                        if (dodgeBrawler >= 90)
                        {
                            brawlerAnimator.Play("dodge");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Brawler Dodge!";


                            brawler = true;
                            robot = false;
                            attackRobot = 0;
                        }

                        if (dodgeBrawler <= 89)
                        {
                            bossAnimator.Play("hit2");

                            if (criticRobot >= 0 && criticRobot <= 50)
                            {
                         
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= (800 * 1.5f);
                                starBattleText.fontSize = 240;
                                starBattleText.text = (800 * 1.5f).ToString() + "CRITIC!";


                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }

                            if (criticRobot >= 51)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 800.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= 800;
                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }





                        }
                    }
                }


                if (chooseRobot == 2)
                {
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedLeon == 1)
                    {
                        if (dodgeBrawler >= 80)
                        {
                            brawlerAnimator.Play("dodge");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Brawler Dodge!";


                            brawler = true;
                            robot = false;
                            attackRobot = 0;
                        }

                        if (dodgeBrawler <= 79)
                        {
                            bossAnimator.Play("hit2");

                            if (criticRobot >= 0 && criticRobot <= 50)
                            {

                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= (600 * 1.5f);
                                starBattleText.fontSize = 240;
                                starBattleText.text = (600 * 1.5f).ToString() + "CRITIC!";


                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }

                            if (criticRobot >= 51)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 600.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= 600;
                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }

                        }
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedBull == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedElPrimo == 1)
                    {
                        if (dodgeBrawler >= 85)
                        {
                            brawlerAnimator.Play("dodge");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Brawler Dodge!";


                            brawler = true;
                            robot = false;
                            attackRobot = 0;
                        }

                        if (dodgeBrawler <= 84)
                        {
                            bossAnimator.Play("hit2");

                            if (criticRobot >= 0 && criticRobot <= 50)
                            {

                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= (600 * 1.5f);
                                starBattleText.fontSize = 240;
                                starBattleText.text = (600 * 1.5f).ToString() + "CRITIC!";


                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }

                            if (criticRobot >= 51)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 600.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= 600;
                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }

                        }
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedShelly == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNita == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedColt == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedBea == 1)
                    {


                        if (dodgeBrawler >= 90)
                        {
                            brawlerAnimator.Play("dodge");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Brawler Dodge!";


                            brawler = true;
                            robot = false;
                            attackRobot = 0;
                        }

                        if (dodgeBrawler <= 89)
                        {
                            bossAnimator.Play("hit2");

                            if (criticRobot >= 0 && criticRobot <= 25)
                            {
             
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= (600 * 1.5f);
                                starBattleText.fontSize = 240;
                                starBattleText.text = (600 * 1.5f).ToString() + "CRITIC!";


                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }

                            if (criticRobot >= 26)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 600.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= 600;
                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }





                        }
                    }
                }


                if (chooseRobot == 1)
                {

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedLeon == 1)
                    {
                        if (dodgeBrawler >= 80)
                        {
                            brawlerAnimator.Play("dodge");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Brawler Dodge!";


                            brawler = true;
                            robot = false;
                            attackRobot = 0;
                        }

                        if (dodgeBrawler <= 79)
                        {
                            bossAnimator.Play("hit2");

                            if (criticRobot >= 0 && criticRobot <= 50)
                            {

                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= (400 * 1.5f);
                                starBattleText.fontSize = 240;
                                starBattleText.text = (400 * 1.5f).ToString() + "CRITIC!";


                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }

                            if (criticRobot >= 51)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 400.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= 400;
                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }

                        }
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedBull == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedElPrimo == 1)
                    {
                        if (dodgeBrawler >= 85)
                        {
                            brawlerAnimator.Play("dodge");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Brawler Dodge!";


                            brawler = true;
                            robot = false;
                            attackRobot = 0;
                        }

                        if (dodgeBrawler <= 84)
                        {
                            bossAnimator.Play("hit2");

                            if (criticRobot >= 0 && criticRobot <= 50)
                            {

                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= (400 * 1.5f);
                                starBattleText.fontSize = 240;
                                starBattleText.text = (400 * 1.5f).ToString() + "CRITIC!";


                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }

                            if (criticRobot >= 51)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 400.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= 400;
                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }

                        }
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedShelly == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNita == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedColt == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedBea == 1)
                    {


                        if (dodgeBrawler >= 90)
                        {
                            brawlerAnimator.Play("dodge");
                            starBattleText.fontSize = 170;
                            starBattleText.text = "Brawler Dodge!";


                            brawler = true;
                            robot = false;
                            attackRobot = 0;
                        }

                        if (dodgeBrawler <= 89)
                        {
                            bossAnimator.Play("hit2");

                            if (criticRobot >= 0 && criticRobot <= 15)
                            {
                    
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= (400 * 1.5f);
                                starBattleText.fontSize = 240;
                                starBattleText.text = (400 * 1.5f).ToString() + "CRITIC!";


                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }

                            if (criticRobot >= 16)
                            {
                                starBattleText.fontSize = 240;
                                starBattleText.text = 300.ToString();
                                GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value -= 400;
                                brawler = true;
                                robot = false;
                                attackRobot = 0;
                            }





                        }
                    }
                }





                if (attackRobot >= 0.6)
                {
                        brawler = true;
                        robot = false;
                        attackRobot = 0;
               }
                
            }
        }


        if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedBull == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4)
        {
            brawlersSelected.GetComponent<Image>().sprite = bullDuels;
        }

        if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedElPrimo == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5)
        {
            brawlersSelected.GetComponent<Image>().sprite = elprimoDuels;
        }

        if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedBea == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6)
        {
            brawlersSelected.GetComponent<Image>().sprite = beaDuels;
        }

        if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedLeon == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7)
        {
            brawlersSelected.GetComponent<Image>().sprite = leonDuels;
        }



        if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedColt == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3)
        {
            brawlersSelected.GetComponent<Image>().sprite = coltDuels;
        }



        if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedShelly == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1)
        {
            brawlersSelected.GetComponent<Image>().sprite = shellyDuels;
        }

        if(GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNita == 1  && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2)
        {
            brawlersSelected.GetComponent<Image>().sprite = nitaDuels;
        }

        if (startBattleBool == true)
        {


            starBattleText.text = startBattle.ToString("F0");
        }

        if (CanvasBrawlers.enabled == true || CanvasBralersEpic.enabled == true || CanvasBrawlersRare.enabled == true)
        {
            brawlersParticle.enableEmission = true;
            brawlersParticle.gameObject.SetActive(true);
        }
        if (startBattleBool)
        {
            startBattle -= Time.deltaTime;

            if (startBattle <= 0 && startBattle > -2)
            {
                starBattleText.text = "Fight!";

            }

            if (startBattle <= -2)
            {

                starBattleText.text = "";
                startBattleBool = false;
                startFight = true;

                startBattle = 3;
            }
        }

        if (CanvasBrawlersLegendary.enabled == true)
        {
            brawlersParticle.enableEmission = false;
            brawlersParticle.gameObject.SetActive(false);
        }

        if (CanvasBralersEpic.enabled == false && CanvasBrawlersRare.enabled == false && CanvasBrawlers.enabled == false)
        {
            brawlersParticle.enableEmission = false;
            brawlersParticle.gameObject.SetActive(false);
        }


        if (quality == 1)
        {
            rare.transform.localScale = new Vector2(1, 1);
            trophy.transform.localScale = new Vector2(0.8f, 0.8f);
            epic.transform.localScale = new Vector2(1, 1);
            legendary.transform.localScale = new Vector2(1, 1);

        }

        if (quality == 2)
        {
            trophy2.transform.localScale = new Vector2(1, 1);
            rare2.transform.localScale = new Vector2(0.8f, 0.8f);
            epic2.transform.localScale = new Vector2(1, 1);
            legendary2.transform.localScale = new Vector2(1, 1);


        }

        if (quality == 3)
        {
            trophy3.transform.localScale = new Vector2(1, 1);
            rare3.transform.localScale = new Vector2(1f, 1f);
            epic3.transform.localScale = new Vector2(0.8f, 0.8f);
            legendary3.transform.localScale = new Vector2(1, 1);
        }

        if (quality == 4)
        {
            trophy4.transform.localScale = new Vector2(1, 1);
            rare4.transform.localScale = new Vector2(1f, 1f);
            epic4.transform.localScale = new Vector2(1, 1);
            legendary4.transform.localScale = new Vector2(0.8f, 0.8f);
        }


    }

    public void upgradesClicked()
    {
        if (GameObject.Find("boxClicker").GetComponent<clickBox>().particle.enableEmission == true)
        {
            GameObject.Find("boxClicker").GetComponent<clickBox>().particle.gameObject.SetActive(false);
        }
        CanvasStart.enabled = false;
        CanvasUpgrades.enabled = true;
        CanvasBrawlers.enabled = false;
        CanvasBrawlersRare.enabled = false;
    }

    public void brawlersClicked()
    {
        if (GameObject.Find("boxClicker").GetComponent<clickBox>().particle.enableEmission == true)
        {
            GameObject.Find("boxClicker").GetComponent<clickBox>().particle.gameObject.SetActive(false);
        }
        quality = 1;
        CanvasBrawlers.enabled = true;
        CanvasStart.enabled = false;
    }

    public void rareChoose()
    {
        quality = 2;

        CanvasBrawlers.enabled = false;
        CanvasBrawlersRare.enabled = true;
        CanvasBralersEpic.enabled = false;
        CanvasBrawlersLegendary.enabled = false;


    }
    public void rightClicked()
    {
        rightClick.GetComponent<Image>().enabled = false;
        leftclick.GetComponent<Image>().enabled = true;
        shelly.GetComponent<Image>().enabled = false;
        nita.GetComponent<Image>().enabled = false;
        colt.GetComponent<Image>().enabled = false;
        bull.GetComponent<Image>().enabled = false;
        elprimo.GetComponent<Image>().enabled = false;
        bae.GetComponent<Image>().enabled = true;
        leon.GetComponent<Image>().enabled = true;
    }


    public void leftClicked()
    {
        rightClick.GetComponent<Image>().enabled = true;
        leftclick.GetComponent<Image>().enabled = false;
        shelly.GetComponent<Image>().enabled = true;
        nita.GetComponent<Image>().enabled = true;
        colt.GetComponent<Image>().enabled = true;
        bull.GetComponent<Image>().enabled = true;
        elprimo.GetComponent<Image>().enabled = true;
        bae.GetComponent<Image>().enabled = false;
        leon.GetComponent<Image>().enabled = false;
    }

    public void DuelsClicked()
    {
        CanvasDuels.enabled = true;
        CanvasStart.enabled = false;
        if (GameObject.Find("boxClicker").GetComponent<clickBox>().particle.enableEmission == true)
        {
            GameObject.Find("boxClicker").GetComponent<clickBox>().particle.gameObject.SetActive(false);
        }
    }
    public void trophyChoose()
    {
        quality = 1;

        CanvasBrawlers.enabled = true;
        CanvasBrawlersRare.enabled = false;
        CanvasBralersEpic.enabled = false;
        CanvasBrawlersLegendary.enabled = false;
    }

    public void epicChoose()

    {
        quality = 3;
        CanvasBrawlers.enabled = false;
        CanvasBrawlersRare.enabled = false;
        CanvasBrawlersLegendary.enabled = false;
        CanvasBralersEpic.enabled = true;
    }

    public void legendaryChoose()
    {
        quality = 4;
        CanvasBrawlers.enabled = false;
        CanvasBrawlersRare.enabled = false;
        CanvasBrawlersLegendary.enabled = true;
        CanvasBralersEpic.enabled = false;
    }

    public void upgradesBack()
    {
        CanvasBea.enabled = false;
        CanvasDuels.enabled = false;
        CanvasBrawlersLegendary.enabled = false;
        CanvasBralersEpic.enabled = false;
        quality = 1;
        CanvasBrawlers.enabled = false;
        CanvasBrawlersRare.enabled = false;
        CanvasStart.enabled = true;
        CanvasUpgrades.enabled = false;
        GameObject.Find("boxClicker").GetComponent<clickBox>().particle.gameObject.SetActive(true);

    }
    public void nextHardFight()
    {
        if (GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value == 0)
        {

            if (chooseRobot == 3)
            {

                GameObject.Find("boxClicker").GetComponent<clickBox>().badgesAmount += 1;
                GameObject.Find("boxClicker").GetComponent<clickBox>().beatHard = 1;
                CanvasShowBadge.enabled = true;
                backgroundBadge.enabled = true;
                badgeShow.Play("badgeShow");

                GameObject.Find("boxClicker").GetComponent<clickBox>().badgeShow.sprite = GameObject.Find("boxClicker").GetComponent<clickBox>().hardBossBeated;
                textBadgeGet.text = "Congratulations!                       You got Hard Robot Badge!";
            }

        }

        checkEnd = 0;
        fightMiddleBoos.enabled = false;
        CanvasDuels.enabled = false;
        CanvasStart.enabled = true;

    }

    public void nextMiddleFight()
    {
        if (GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value == 0)
        {

            if (chooseRobot == 2)
            {

                GameObject.Find("boxClicker").GetComponent<clickBox>().badgesAmount += 1;
                GameObject.Find("boxClicker").GetComponent<clickBox>().beatMiddle = 1;
                CanvasShowBadge.enabled = true;
                backgroundBadge.enabled = true;
                badgeShow.Play("badgeShow");

                GameObject.Find("boxClicker").GetComponent<clickBox>().badgeShow.sprite = GameObject.Find("boxClicker").GetComponent<clickBox>().middleBossBeated;
                textBadgeGet.text = "Congratulations!                       You got Middle Robot Badge!";
            }

        }

        checkEnd = 0;
        fightMiddleBoos.enabled = false;
        CanvasDuels.enabled = false;
        CanvasStart.enabled = true;
      
    }

    public void nextEasyFight()
    {
        if (GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value == 0)
        {
            if (chooseRobot == 1)
            {

                GameObject.Find("boxClicker").GetComponent<clickBox>().badgesAmount += 1;
                GameObject.Find("boxClicker").GetComponent<clickBox>().beatEasy = 1;
                CanvasShowBadge.enabled = true;
                backgroundBadge.enabled = true;
                badgeShow.Play("badgeShow");

                GameObject.Find("boxClicker").GetComponent<clickBox>().badgeShow.sprite = GameObject.Find("boxClicker").GetComponent<clickBox>().easyBossBeated;
                textBadgeGet.text = "Congratulations!                       You got Easy Robot Badge!";
            }

        }

        checkEnd = 0;
        fightMiddleBoos.enabled = false;
        CanvasDuels.enabled = false;
        CanvasStart.enabled = true;

    }

    public void badgeClicked()
    {
        CanvasBadge.enabled = true;
        CanvasStart.enabled = false;
        GameObject.Find("boxClicker").GetComponent<clickBox>().particle.gameObject.SetActive(false);
    }
    public void clickedCompleted()
    {

 

        if (allBadgesFloat >= 3)
        {


            CanvasAllBadges.enabled = false;
            allBadges = 1;
            allBadgesBool = false;
        }
    }

    public void badgeWroc()
    {
        if(GameObject.Find("boxClicker").GetComponent<clickBox>().badgesAmount == 12 && allBadges == 0)
        {
            CanvasAllBadges.enabled = true;

      

        }

        allBadgesBool = true;
        toolbar.transform.position = new Vector2(167, 350);
        CanvasBadge.enabled = false;
        GameObject.Find("boxClicker").GetComponent<clickBox>().particle.gameObject.SetActive(true);
        CanvasStart.enabled = true;
    }
    public void clickBackgroundBadge()
    {
        textBadgeGet.enabled = false;
        backgroundBadge.enabled = false;
        badgeadd = true;
        transformBadge.Play("transform");
        checkBadgeOn = true;
    }

    public void clickEasyBoss()
    {

        if (GameObject.Find("boxClicker").GetComponent<clickBox>().beatEasy == 0)
        {


            if (GameObject.Find("boxClicker").GetComponent<clickBox>().tickets == 0)
            {
                redTickets.Play("red");
            }

            if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 0)
            {
                noChoose.Play("no");
            }

            if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 0 && GameObject.Find("boxClicker").GetComponent<clickBox>().watchedAds == 0)
            {
                noChoose.Play("no");


            }

            if (GameObject.Find("boxClicker").GetComponent<clickBox>().tickets >= 1 && (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber > 0 && instagramBonus == 0))
            {
                chooseRobot = 1;

                robotImage.sprite = easystats;

                if (GameObject.Find("boxClicker").GetComponent<clickBox>().beatEasy == 0)
                {
                    GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.maxValue = 5000;
                    GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value = 5000;

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000;
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (3600 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (3200 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (2880 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (4900 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (3360 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800;
                    }



                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (3200 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (2880 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (4900 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (3360 * 0.5f);
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (4000 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (3600 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (3200 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (4900 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (3360 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (4000 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (3600 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (2880 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (4900 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (3360 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (4000 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (3600 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (3200 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (2880 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (3360 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (4000 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (3600 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360;
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (3600 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (4000 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (4900 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (2880 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7 && instagramBonus == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (3200 * 0.5f);
                    }



                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0 && instagramBonus == 0)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600;


                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7 && instagramBonus == 0)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (3200 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6 && instagramBonus == 0)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (2880 * 0.5f);
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5 && instagramBonus == 0)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4 && instagramBonus == 0)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (4900 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3 && instagramBonus == 0)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (3360 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2 && instagramBonus == 0)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (4000 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000;
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (3600 * 0.5f);
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (3200 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (2880 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (4900 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (3360 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800;
                    }



                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (3200 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (2880 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (4900 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (3360 * 0.5f);
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (4000 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (3600 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (3200 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (4900 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (3360 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (4000 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (3600 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (2880 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (4900 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (3360 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (4000 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (3600 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (3200 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (2880 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (3360 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (4000 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (3600 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360;
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (3600 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (4000 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (4900 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (2880 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7 && instagramBonus == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (3200 * 0.5f);
                    }



                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0 && instagramBonus == 1)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600;


                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7 && instagramBonus == 1)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (3200 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6 && instagramBonus == 1)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (2880 * 0.5f);
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5 && instagramBonus == 1)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4 && instagramBonus == 1)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (4900 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3 && instagramBonus == 1)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (3360 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2 && instagramBonus == 1)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3600 + (4000 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3600 + (4000 * 0.5f)) * 1.1f;
                    }



                    GameObject.Find("boxClicker").GetComponent<clickBox>().tickets -= 1;
                    fightMiddleBoos.enabled = true;
                    CanvasDuels.enabled = false;


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedColt == 1)
                    {


                        bullets1 = Random.Range(1, 100);
                        bullets2 = Random.Range(1, 100);
                        bullets3 = Random.Range(1, 100);
                        bullets4 = Random.Range(1, 100);
                        bullets5 = Random.Range(1, 100);
                        bullets6 = Random.Range(1, 100);

                        if (bullets1 >= 1)
                        {
                            bulletsOneBool = true;
                        }

                        if (bullets2 >= 20)
                        {
                            bulletsOneBool2 = true;
                        }


                        if (bullets3 >= 40)
                        {
                            bulletsOneBool3 = true;
                        }


                        if (bullets4 >= 60)
                        {
                            bulletsOneBool4 = true;
                        }


                        if (bullets5 >= 80)
                        {
                            bulletsOneBool5 = true;
                        }


                        if (bullets6 >= 90)
                        {
                            bulletsOneBool6 = true;
                        }

                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedShelly == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedBull == 1)
                    {


                        bullets1 = Random.Range(1, 100);
                        bullets2 = Random.Range(1, 100);
                        bullets3 = Random.Range(1, 100);
                        bullets4 = Random.Range(1, 100);
                        bullets5 = Random.Range(1, 100);


                        if (bullets1 >= 1)
                        {
                            bulletsOneBool = true;
                        }

                        if (bullets2 >= 25)
                        {
                            bulletsOneBool2 = true;
                        }


                        if (bullets3 >= 50)
                        {
                            bulletsOneBool3 = true;
                        }


                        if (bullets4 >= 75)
                        {
                            bulletsOneBool4 = true;
                        }


                        if (bullets5 >= 90)
                        {
                            bulletsOneBool5 = true;
                        }



                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedElPrimo == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedLeon == 1)
                    {


                        bullets1 = Random.Range(1, 100);
                        bullets2 = Random.Range(1, 100);
                        bullets3 = Random.Range(1, 100);
                        bullets4 = Random.Range(1, 100);



                        if (bullets1 >= 1)
                        {
                            bulletsOneBool = true;
                        }

                        if (bullets2 >= 30)
                        {
                            bulletsOneBool2 = true;
                        }


                        if (bullets3 >= 60)
                        {
                            bulletsOneBool3 = true;
                        }


                        if (bullets4 >= 90)
                        {
                            bulletsOneBool4 = true;
                        }






                    }



                    startBattleBool = true;
                }






            }
        }
    }
    public void clickMiddleBoss()
    {
        if (GameObject.Find("boxClicker").GetComponent<clickBox>().beatMiddle == 0)
        {



            if (GameObject.Find("boxClicker").GetComponent<clickBox>().tickets < 2)
            {
                redTickets.Play("red");
            }

            if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 0)
            {
                noChoose.Play("no");
            }

            if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 0 && GameObject.Find("boxClicker").GetComponent<clickBox>().watchedAds == 0)
            {
                noChoose.Play("no");


            }

            if (GameObject.Find("boxClicker").GetComponent<clickBox>().tickets >= 2 && (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber != 0))
            {

                robotImage.sprite = middlestats;

                chooseRobot = 2;

                if (GameObject.Find("boxClicker").GetComponent<clickBox>().beatMiddle == 0)
                {
                    GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.maxValue = 10000;
                    GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value = 10000;



                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 * 1.1f;
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (4000 + (3600 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (4000 + (3600 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (4000 + (3200 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (4000 + (3200 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (4000 + (2880 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (4000 + (2880 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (4000 + (5800 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (4000 + (5800 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (4000 + (4900 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (4000 + (4900 * 0.5f)) * 1.1f;
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (4000 + (3360 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (4000 + (3360 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 * 1.1f;
                    }



                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (5800 + (3200 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (5800 + (3200 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3200 + (2880 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3200 + (2880 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3200 + (5800 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3200 + (5800 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3200 + (4900 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3200 + (4900 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3200 + (3360 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3200 + (3360 * 0.5f)) * 1.1f;
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3200 + (4000 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3200 + (4000 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3200 + (3600 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3200 + (3600 * 0.5f)) * 1.1f;
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (2880 + (3200 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (2880 + (3200 * 0.5f)) * 1.1f;
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (2880 + (5800 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (2880 + (5800 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (2880 + (4900 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (2880 + (4900 * 0.5f)) * 1.1f;
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (2880 + (3360 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (2880 + (3360 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (2880 + (4000 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (2880 + (4000 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (2880 + (3600 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (2880 + (3600 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (5800 + (2880 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (5800 + (2880 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (5800 + (4900 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (5800 + (4900 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (5800 + (3360 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (5800 + (3360 * 0.5f)) * 1.1f;
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (5800 + (4000 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (5800 + (4000 * 0.5f)) * 1.1f;
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (5800 + (3600 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (5800 + (3600 * 0.5f)) * 1.1f;
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (4900 + (3200 * 0.5f) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (4900 + (3200 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (4900 + (2880 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (4900 + (2880 * 0.5f)) * 1.1f;
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (4900 + (5800 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (4900 + (5800 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (4900 + (3360 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (4900 + (3360 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (4900 + (4000 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (4900 + (4000 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (4900 + (3600 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (4900 + (3600 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3360 * 1.1f);
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3360 + (3600 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3360 + (3600 * 0.5f)) * 1.1f;
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3360 + (4000 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3360 + (4000 * 0.5f)) * 1.1f;
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3360 + (4900 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3360 + (4900 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3360 + (5800 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3360 + (5800 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3360 + (2880 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3360 + (2880 * 0.5f)) * 1.1f;
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3360 + (3200 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3360 + (3200 * 0.5f)) * 1.1f;
                    }



                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 * 1.1f;


                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3600 + (3200 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3600 + (3200 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3600 + (2880 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3600 + (2880 * 0.5f)) * 1.1f;
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3600 + (5800 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3600 + (5800 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3600 + (4900 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3600 + (4900 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3600 + (3360 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3600 + (3360 * 0.5f)) * 1.1f;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = (3600 + (4000 * 0.5f)) * 1.1f;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = (3600 + (4000 * 0.5f)) * 1.1f;
                    }
                    GameObject.Find("boxClicker").GetComponent<clickBox>().tickets -= 2;
                    fightMiddleBoos.enabled = true;
                    CanvasDuels.enabled = false;



                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedColt == 1)
                    {
                        bullets1 = Random.Range(1, 100);
                        bullets2 = Random.Range(1, 100);
                        bullets3 = Random.Range(1, 100);
                        bullets4 = Random.Range(1, 100);
                        bullets5 = Random.Range(1, 100);
                        bullets6 = Random.Range(1, 100);

                        if (bullets1 >= 1)
                        {
                            bulletsOneBool = true;
                        }

                        if (bullets2 >= 20)
                        {
                            bulletsOneBool2 = true;
                        }


                        if (bullets3 >= 40)
                        {
                            bulletsOneBool3 = true;
                        }


                        if (bullets4 >= 60)
                        {
                            bulletsOneBool4 = true;
                        }


                        if (bullets5 >= 80)
                        {
                            bulletsOneBool5 = true;
                        }


                        if (bullets6 >= 90)
                        {
                            bulletsOneBool6 = true;
                        }

                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedShelly == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedBull == 1)
                    {


                        bullets1 = Random.Range(1, 100);
                        bullets2 = Random.Range(1, 100);
                        bullets3 = Random.Range(1, 100);
                        bullets4 = Random.Range(1, 100);
                        bullets5 = Random.Range(1, 100);


                        if (bullets1 >= 1)
                        {
                            bulletsOneBool = true;
                        }

                        if (bullets2 >= 25)
                        {
                            bulletsOneBool2 = true;
                        }


                        if (bullets3 >= 50)
                        {
                            bulletsOneBool3 = true;
                        }


                        if (bullets4 >= 75)
                        {
                            bulletsOneBool4 = true;
                        }


                        if (bullets5 >= 90)
                        {
                            bulletsOneBool5 = true;
                        }



                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedElPrimo == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedLeon == 1)
                    {


                        bullets1 = Random.Range(1, 100);
                        bullets2 = Random.Range(1, 100);
                        bullets3 = Random.Range(1, 100);
                        bullets4 = Random.Range(1, 100);



                        if (bullets1 >= 1)
                        {
                            bulletsOneBool = true;
                        }

                        if (bullets2 >= 30)
                        {
                            bulletsOneBool2 = true;
                        }


                        if (bullets3 >= 60)
                        {
                            bulletsOneBool3 = true;
                        }


                        if (bullets4 >= 90)
                        {
                            bulletsOneBool4 = true;
                        }






                    }



                    startBattleBool = true;
                }






            }

        }

    }


    public void clickHardBoss()
    {

        if (GameObject.Find("boxClicker").GetComponent<clickBox>().beatHard == 0)
        {


            if (GameObject.Find("boxClicker").GetComponent<clickBox>().tickets < 3)
            {
                redTickets.Play("red");
            }

            if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 0)
            {
                noChoose.Play("no");
            }

            if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 0 && GameObject.Find("boxClicker").GetComponent<clickBox>().watchedAds == 0)
            {
                noChoose.Play("no");


            }

            if (GameObject.Find("boxClicker").GetComponent<clickBox>().tickets >= 3 && (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber != 0))
            {

                chooseRobot = 3;

                robotImage.sprite = hardstats;

                if (GameObject.Find("boxClicker").GetComponent<clickBox>().beatHard == 0)
                {
                    GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.maxValue = 20000;
                    GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value = 20000;



                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000;
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (3600 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (3200 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (2880 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (4900 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 2 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4000 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4000 + (3360 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800;
                    }



                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (3200 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (2880 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (4900 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (3360 * 0.5f);
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (4000 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200 + (3600 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 7 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3200;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3200;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (3200 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (4900 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (3360 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (4000 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880 + (3600 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 6 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 2880;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 2880;
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (2880 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (4900 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (3360 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (4000 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 5 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 5800 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 5800 + (3600 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (3200 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (2880 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (3360 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (4000 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 4 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 4900 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 4900 + (3600 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360;
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 1)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (3600 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (3600 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (4000 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (4900 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (2880 * 0.5f);
                    }


                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 3 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                    {



                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3360 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3360 + (3200 * 0.5f);
                    }



                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 0)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600;
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600;


                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 7)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (3200 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (3200 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 6)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (2880 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (2880 * 0.5f);
                    }
                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 5)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (5800 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (5800 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 4)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (4900 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (4900 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 3)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (3360 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (3360 * 0.5f);
                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber == 1 && GameObject.Find("boxClicker").GetComponent<clickBox>().selectedNumber2 == 2)
                    {


                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue = 3600 + (4000 * 0.5f);
                        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = 3600 + (4000 * 0.5f);
                    }
                    GameObject.Find("boxClicker").GetComponent<clickBox>().tickets -= 3;
                    fightMiddleBoos.enabled = true;
                    CanvasDuels.enabled = false;



                    startBattleBool = true;

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedColt == 1)
                    {
                        bullets1 = Random.Range(1, 100);
                        bullets2 = Random.Range(1, 100);
                        bullets3 = Random.Range(1, 100);
                        bullets4 = Random.Range(1, 100);
                        bullets5 = Random.Range(1, 100);
                        bullets6 = Random.Range(1, 100);

                        if (bullets1 >= 1)
                        {
                            bulletsOneBool = true;
                        }

                        if (bullets2 >= 20)
                        {
                            bulletsOneBool2 = true;
                        }


                        if (bullets3 >= 40)
                        {
                            bulletsOneBool3 = true;
                        }


                        if (bullets4 >= 60)
                        {
                            bulletsOneBool4 = true;
                        }


                        if (bullets5 >= 80)
                        {
                            bulletsOneBool5 = true;
                        }


                        if (bullets6 >= 90)
                        {
                            bulletsOneBool6 = true;
                        }

                    }



                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedShelly == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedBull == 1)
                    {


                        bullets1 = Random.Range(1, 100);
                        bullets2 = Random.Range(1, 100);
                        bullets3 = Random.Range(1, 100);
                        bullets4 = Random.Range(1, 100);
                        bullets5 = Random.Range(1, 100);


                        if (bullets1 >= 1)
                        {
                            bulletsOneBool = true;
                        }

                        if (bullets2 >= 25)
                        {
                            bulletsOneBool2 = true;
                        }


                        if (bullets3 >= 50)
                        {
                            bulletsOneBool3 = true;
                        }


                        if (bullets4 >= 75)
                        {
                            bulletsOneBool4 = true;
                        }


                        if (bullets5 >= 90)
                        {
                            bulletsOneBool5 = true;
                        }



                    }

                    if (GameObject.Find("boxClicker").GetComponent<clickBox>().selectedElPrimo == 1 || GameObject.Find("boxClicker").GetComponent<clickBox>().selectedLeon == 1)
                    {


                        bullets1 = Random.Range(1, 100);
                        bullets2 = Random.Range(1, 100);
                        bullets3 = Random.Range(1, 100);
                        bullets4 = Random.Range(1, 100);



                        if (bullets1 >= 1)
                        {
                            bulletsOneBool = true;
                        }

                        if (bullets2 >= 30)
                        {
                            bulletsOneBool2 = true;
                        }


                        if (bullets3 >= 60)
                        {
                            bulletsOneBool3 = true;
                        }


                        if (bullets4 >= 90)
                        {
                            bulletsOneBool4 = true;
                        }






                    }


                }






            }

        }


    }

    public void shardsBack()
    {

   
        CanvasShards.enabled = false;
        CanvasUpgrades.enabled = true;
        mortisParticle.gameObject.SetActive(false);
        taraParticle.gameObject.SetActive(false);
        taraParticle.gameObject.SetActive(false);
    }

    public void settingsClicked()
    {
        GameObject.Find("boxClicker").GetComponent<clickBox>().particle.gameObject.SetActive(false);
        CanvasSettings.enabled = true;
        CanvasStart.enabled = false;
    }

    public void settingsBack()
    {
        GameObject.Find("boxClicker").GetComponent<clickBox>().particle.gameObject.SetActive(true);
        CanvasSettings.enabled = false;
        CanvasStart.enabled = true;
    }
    public void shardsClicked()
    {
  
        CanvasShards.enabled = true;
        CanvasUpgrades.enabled = false;
        mortisParticle.gameObject.SetActive(true);
        taraParticle.gameObject.SetActive(true);
    }
    public void choose2Clicked()
    {
        CanvasChoose2.enabled = true;
        CanvasDuels.enabled = false;

    }

    public void choose2Back()
    {
        CanvasChoose2.enabled = false;
        CanvasDuels.enabled = true;
    }

    public void choose1Clicked()
    {
        CanvasChoose1.enabled = true;
        CanvasDuels.enabled = false;

    }

    public void choose1Back()
    {
        CanvasChoose2.enabled = false;
        CanvasChoose1.enabled = false;
        CanvasDuels.enabled = true;
    }

    public void coltClicked()
    {
        CanvasColt.enabled = true;
        CanvasStart.enabled = false;
        CanvasBrawlers.enabled = false;
        if (GameObject.Find("boxClicker").GetComponent<clickBox>().particle.enableEmission == true)
        {
            GameObject.Find("boxClicker").GetComponent<clickBox>().particle.gameObject.SetActive(false);
        }
    }
    
    public void shellyClicked()
    {
        CanvasShelly.enabled = true;
        CanvasStart.enabled = false;
        CanvasBrawlers.enabled = false;
        if (GameObject.Find("boxClicker").GetComponent<clickBox>().particle.enableEmission == true)
        {
            GameObject.Find("boxClicker").GetComponent<clickBox>().particle.gameObject.SetActive(false);
        }
    }

    public void reviveBack()
    {
        CanvasADMORE.enabled = false;
        

    }
    public void reviveBrawler()
    {
        
        CanvasADMORE.enabled = false;
        GameObject.Find("boxClicker").GetComponent<clickBox>().hpMiddleRobot.value *= 1.50f;
        GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.value = GameObject.Find("boxClicker").GetComponent<clickBox>().hpBrawler.maxValue;
        robot = false;
        brawler = true;
    }

    public void elPrimoClicked()
    {
        CanvasBrawlersRare.enabled = false;
        CanvasStart.enabled = false;
        CanvasElPrimo.enabled = true;
        CanvasBrawlers.enabled = false;
        if (GameObject.Find("boxClicker").GetComponent<clickBox>().particle.enableEmission == true)
        {
            GameObject.Find("boxClicker").GetComponent<clickBox>().particle.gameObject.SetActive(false);
        }


    }

    public void beaClicked()
    {
        CanvasStart.enabled = false;
        CanvasBea.enabled = true;
        CanvasBrawlers.enabled = false;
        CanvasBralersEpic.enabled = false;
        if (GameObject.Find("boxClicker").GetComponent<clickBox>().particle.enableEmission == true)
        {
            GameObject.Find("boxClicker").GetComponent<clickBox>().particle.gameObject.SetActive(false);
        }


    }

    public void leonClicked()
    {

        CanvasBrawlersLegendary.enabled = false;
        CanvasStart.enabled = false;
        CanvasLeon.enabled = true;
        CanvasBrawlers.enabled = false;
        if (GameObject.Find("boxClicker").GetComponent<clickBox>().particle.enableEmission == true)
        {
            GameObject.Find("boxClicker").GetComponent<clickBox>().particle.gameObject.SetActive(false);
        }


    }
    public void bullClicked()
    {
        CanvasStart.enabled = false;
        CanvasBull.enabled = true;
        CanvasBrawlers.enabled = false;
        if (GameObject.Find("boxClicker").GetComponent<clickBox>().particle.enableEmission == true)
        {
            GameObject.Find("boxClicker").GetComponent<clickBox>().particle.gameObject.SetActive(false);
        }


    }
    public void nitaClicked()
    {
        CanvasStart.enabled = false;
        CanvasNita.enabled = true;
        CanvasBrawlers.enabled = false;
        if (GameObject.Find("boxClicker").GetComponent<clickBox>().particle.enableEmission == true)
        {
            GameObject.Find("boxClicker").GetComponent<clickBox>().particle.gameObject.SetActive(false);
        }
    }

    public void nitaBack()
    {
        CanvasStart.enabled = false;
        CanvasNita.enabled = false;
        CanvasBrawlers.enabled = true;
    }
    public void shellyBack()
    {
        CanvasStart.enabled = false;
        CanvasShelly.enabled = false;
        CanvasBrawlers.enabled = true;
    }
    public void leonBack()
    {
        CanvasStart.enabled = false;
        CanvasLeon.enabled = false;
        CanvasBrawlersLegendary.enabled = true;
    }
    public void beaBack()
    {
        CanvasBea.enabled = false;
        CanvasStart.enabled = false;
   
        CanvasBralersEpic.enabled = true;
    }
    public void elprimoBack()
    {
        CanvasStart.enabled = false;
        CanvasElPrimo.enabled = false;
        CanvasBrawlersRare.enabled = true;
    }
    public void bullBack()
    {
        CanvasStart.enabled = false;
        CanvasBull.enabled = false;
        CanvasBrawlers.enabled = true;
    }
    public void coltBack()
    {
        CanvasStart.enabled = false;
        CanvasColt.enabled = false;
        CanvasBrawlers.enabled = true;
    }
}
