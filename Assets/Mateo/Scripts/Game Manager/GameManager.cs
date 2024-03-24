using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
 private int crystals=0;
 private int crystalsNeeded;
 public int Crystals{
     get{
      return crystals;
     }
     set{
      crystals = value;
     }
    }
 private int hp=0;
 public int HP{
  get{
   return hp;
  }
  set{
   hp = value;
  }
 }

GameStatus gameStatus = new GameStatus();

void Start(){
 Debug.Log(gameStatus.gameLoop);
}


 public void RemoveHP(){
  hp--;
 }

 public void AddCrystal(){
  crystals++;
 }

 public void SetCrystalsNeeded(int needed){
  crystalsNeeded = needed;
 }


 public bool CrystalCheck(){
  if(crystals >= crystalsNeeded){
   return true;
  }
  return false;
 }



}
