// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using System.Linq;

// public class PathMarker
// {
//   public MapLocation location;
//   public float G;
//   public float H;
//   public float F;
//   public GameObject marker;
//   public PathMarker parent;

//   public PathMarker(MapLocation l, float g, float h, float f, GameObject m, PathMarker p)
//   {
//     location = l;
//     G = g;
//     H = h;
//     F = f;
//     marker = m;
//     parent = p;
//   }

//   public override bool Equals(object obj)
//   {
//     if ((obj == null) || !this.GetType().Equals(obj.GetType())) return false;

//     return location.Equals(((PathMarker) obj).location);

//     PathMarker p = (PathMarker)obj;
//     return location.Equals(p.location);
//   }

//   public override int GetHashCode()
//   {
//     return 0;
//   }
// }

// public class AStarPathfind : MonoBehaviour
// {
//   public MazeGenerator maze;
//   public Material closedMaterial;
//   public Material openMaterial;

//   List<PathMarker> open = new List<PathMarker>();
//   List<PathMarker> closed = new List<PathMarker>();

//   public GameObject start;
//   public GameObject end;
//   public GameObject pathP;

//   PathMarker startMarker;
//   PathMarker endMarker;
//   PathMarker lastPos;

//   bool done = false;

//   void Update()
//   {
//     if(Input.GetKeyDown(KeyCode.Space))
//       BeginSearch();
//   }

//   private void RemoveAllMarkers()
//   {
//     GameObject[] markers = GameObject.FindGameObjectsWithTag("marker");
//     foreach (GameObject m in markers)
//       Destroy(m);
//   }

//   private void BeginSearch()
//   {
//     done = false;
//     RemoveAllMarkers();

//     List<MapLocation> locations = new List<MapLocation>();
//     for (int z = 1; z < maze.depth -1; z++)
//     {
//       for (int x = 1; x < maze.width -1; x++)
//       {
//         if (maze.map[x, z] != 1){
//           locations.Add(new MapLocation(x, z));
//         }
//       }
//     }

//     locations.Shuffle();

//     Vector3 startLocation = new Vector3(locations[0].x, 0.5f, locations[0].z);
//     startMarker = new PathMarker(
//       new MapLocation(locations[0].x, locations[0].z), 0, 0, 0, Instantiate(start, startLocation, Quaternion.identity), null
//     );

//     Vector3 endLocation = new Vector3(locations[1].x, 0.5f, locations[1].z);
//     endMarker = new PathMarker(
//       new MapLocation(locations[1].x, locations[1].z), 0, 0, 0, Instantiate(end, endLocation, Quaternion.identity), null
//     );
//   }
// }
