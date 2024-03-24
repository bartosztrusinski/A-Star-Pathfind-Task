// using System.Collections;
// using System.Collections.Generic;
// using System.Linq;
// using UnityEngine;

// public class MazeGenerator : MonoBehaviour
// {
//   public MazeCell mazeCellPrefab;
//   public int mazeWidth;
//   public int mazeDepth;

//   public MazeCell[,] mazeGrid;

//   void Start()
//   {
//     mazeGrid = new MazeCell[mazeWidth, mazeDepth];

//     FillMaze();

//     GenerateMaze(null, mazeGrid[0, 0]); 
//   }

//   private void FillMaze()
//   {
//     for (int x = 0; x < mazeWidth; x++)
//     {
//       for (int z = 0; z < mazeDepth; z++)
//       {
//         mazeGrid[x, z] = Instantiate(mazeCellPrefab, new Vector3(x, 0, z), Quaternion.identity);
//       }
//     }
//   }

//   private void GenerateMaze(MazeCell previousCell, MazeCell currentCell)
//   {
//     currentCell.Visit();
//     KnockDownWalls(previousCell, currentCell);
    
//     MazeCell nextCell;

//     do {
//       nextCell = GetNextUnvisitedCell(currentCell);

//       if (nextCell) GenerateMaze(currentCell, nextCell);
//     } while (nextCell);
//   }

//   private MazeCell GetNextUnvisitedCell(MazeCell currentCell)
//   {
//     var unvisitedCells = GetUnvisitedCells(currentCell).ToList();

//     return unvisitedCells.OrderBy(_ => Random.Range(1, 10)).FirstOrDefault();
//   }

//   private IEnumerable<MazeCell> GetUnvisitedCells(MazeCell currentCell)
//   {
//     int x = (int)currentCell.transform.position.x;
//     int z = (int)currentCell.transform.position.z;
//     MazeCell leftCell = x > 0 ? mazeGrid[x - 1, z] : null;
//     MazeCell rightCell = x < mazeWidth - 1 ? mazeGrid[x + 1, z] : null;
//     MazeCell frontCell = z > 0 ? mazeGrid[x, z - 1] : null;
//     MazeCell backCell = z < mazeDepth - 1 ? mazeGrid[x, z + 1] : null;

//     if(leftCell && !leftCell.IsVisited) yield return leftCell;
//     if(rightCell && !rightCell.IsVisited) yield return rightCell;
//     if(frontCell && !frontCell.IsVisited) yield return frontCell;
//     if(backCell && !backCell.IsVisited) yield return backCell;
//   }

//   private void KnockDownWalls(MazeCell previousCell, MazeCell currentCell)
//   {
//     if (!previousCell) return;

//     bool isPreviousCellLeft = previousCell.transform.position.x < currentCell.transform.position.x;
//     bool isPreviousCellRight = previousCell.transform.position.x > currentCell.transform.position.x;
//     bool isPreviousCellFront = previousCell.transform.position.z > currentCell.transform.position.z;
//     bool isPreviousCellBack = previousCell.transform.position.z < currentCell.transform.position.z;

//     if (isPreviousCellLeft)
//     {
//       previousCell.RemoveWall(MazeCell.Side.Right);
//       currentCell.RemoveWall(MazeCell.Side.Left);
//       return;
//     }
    
//     if (isPreviousCellRight)
//     {
//       previousCell.RemoveWall(MazeCell.Side.Left);
//       currentCell.RemoveWall(MazeCell.Side.Right);
//       return;
//     }
    
//     if (isPreviousCellFront)
//     {
//       previousCell.RemoveWall(MazeCell.Side.Back);
//       currentCell.RemoveWall(MazeCell.Side.Front);
//       return;
//     }
    
//     if (isPreviousCellBack)
//     {
//       previousCell.RemoveWall(MazeCell.Side.Front);
//       currentCell.RemoveWall(MazeCell.Side.Back);
//       return;
//     }
//   }
// }
