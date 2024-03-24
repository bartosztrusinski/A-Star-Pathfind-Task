// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class MazeCell : MonoBehaviour
// {
//   public enum Side
//   {
//     Left,
//     Right,
//     Front,
//     Back
//   }

//   public GameObject leftWall;
//   public GameObject rightWall;
//   public GameObject frontWall;
//   public GameObject backWall;
//   public GameObject unvisitedBlock;

//   public bool IsVisited { get; private set; }

//   public void Visit()
//   {
//     IsVisited = true;
//     unvisitedBlock.SetActive(false);
//   }

//   public void RemoveWall(Side side)
//   {
//     switch (side)
//     {
//       case Side.Left:
//         leftWall.SetActive(false);
//         break;
//       case Side.Right:
//         rightWall.SetActive(false);
//         break;
//       case Side.Front:
//         frontWall.SetActive(false);
//         break;
//       case Side.Back:
//         backWall.SetActive(false);
//         break;
//     }
//   }

// }
