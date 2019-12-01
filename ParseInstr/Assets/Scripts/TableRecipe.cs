﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Utilities;
using Newtonsoft.Json;
using System.IO;
using System.Web;


namespace RecipeTable
{
    [System.Serializable]
    public class DishData
    {
        public string id;
        public string name;
        public string source;
        public int preptime;
        public int waittime;
        public int cooktime;
        public int servings;
        public string comments;
        public int calories;
        public int fat;
        public int satfat;
        public int carbs;
        public int fiber;
        public int sugar;
        public int protein;
        public string instructions;
        public List<string> ingredients;
        public List<string> tags;
    }

    [System.Serializable]
    class DishesData
    {
        public List<DishData> dishes;

        public static DishesData FromJSON(string json)
        {
            return JsonUtility.FromJson<DishesData>(json);
        }
    }




    public class TableRecipe : MonoBehaviour
    {
        // What object to parent the instantiated elements to
        public Transform Parent;

        // Generic element prefab to instantiate at each position in the table
        public GameObject ElementPrefab;

        private bool isFirstrun = true;
        // How much space to put between each element prefab
        public float ElementSeperationDistance;

        // Legend
        public Transform LegendTransform;

        public GridObjectCollection Collection;

        /*
        public Material MatAlkaliMetal;
        public Material MatAlkalineEarthMetal;
        public Material MatTransitionMetal;
        public Material MatMetalloid;
        public Material MatDiatomicNonmetal;
        public Material MatPolyatomicNonmetal;
        public Material MatPostTransitionMetal;
        public Material MatNobleGas;
        public Material MatActinide;
        public Material MatLanthanide;
        */
    

        private void Start()
        {
            InitializeData();
        }


        public void InitializeData()
        {
            // Parse the elements out of the json file
            TextAsset asset = Resources.Load<TextAsset>("JSON/db");
            List<DishData> dishes = DishesData.FromJSON(asset.text).dishes;

            /*Dictionary<string, Material> typeMaterials = new Dictionary<string, Material>()
            {
            { "alkali metal", MatAlkaliMetal },
            { "alkaline earth metal", MatAlkalineEarthMetal },
            { "transition metal", MatTransitionMetal },
            { "transition metal", MatTransitionMetal },
            { "metalloid", MatMetalloid },
            { "diatomic nonmetal", MatDiatomicNonmetal },
            { "polyatomic nonmetal", MatPolyatomicNonmetal },
            { "post-transition metal", MatPostTransitionMetal },
            { "noble gas", MatNobleGas },
            { "actinide", MatActinide },
            { "lanthanide", MatLanthanide },
            };
            */


            if (isFirstrun == true)
            {
		int i = 0;
		int j = 0;

                // Insantiate the element prefabs in their correct locations and with correct text
                foreach (DishData dish in dishes)
                {
                    GameObject newElement = Instantiate<GameObject>(ElementPrefab, Parent);
                    //newElement.GetComponentInChildren<Dish>().SetFromDishData(dish, typeMaterials);
                    newElement.GetComponentInChildren<Dish>().SetFromDishData(dish);
                    //newElement.transform.localPosition = new Vector3(Int32.Parse(dish.id) * ElementSeperationDistance - ElementSeperationDistance * 18 / 2, ElementSeperationDistance * 9 - Int32.Parse(dish.id) * ElementSeperationDistance, 2.0f);
                    newElement.transform.localPosition = new Vector3( i* ElementSeperationDistance - ElementSeperationDistance * 18 / 2, ElementSeperationDistance * 9 - j * ElementSeperationDistance, 2.0f);
                    newElement.transform.localRotation = Quaternion.identity;

		    j += 1;
                }
                isFirstrun = false;
            }
            else
            {

                int i = 0;
                // Update position and data of existing element objects
                foreach (Transform existingElementObject in Parent)
                {
                    existingElementObject.parent.GetComponentInChildren<Dish>().SetFromDishData(dishes[i]);
                    existingElementObject.localPosition = new Vector3(Int32.Parse(dishes[i].id) * ElementSeperationDistance - ElementSeperationDistance * 18 /2 , ElementSeperationDistance * 9 - Int32.Parse(dishes[i].id) * ElementSeperationDistance, 2.0f);
                    existingElementObject.localRotation = Quaternion.identity;
                    i++;
                }
                Parent.localPosition = new Vector3(0.0f, -0.7f, 0.7f);
                LegendTransform.localPosition = new Vector3(0.0f, 0.15f, 1.8f);
            }

        }    
    }

}