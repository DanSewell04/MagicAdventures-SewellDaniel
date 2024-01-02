using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    public Transform[] waypoints; // Array to hold waypoints
    public float speed = 5.0f; // Speed of movement

    private int currentWaypoint = 0; // Index of current waypoint

    void Update()
    {
        if (waypoints.Length == 0)
            return;

        // Move towards the current waypoint
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypoint].position, speed * Time.deltaTime);

        // If the object reaches the current waypoint, move to the next one
        if (Vector3.Distance(transform.position, waypoints[currentWaypoint].position) < 0.1f)
        {
            currentWaypoint = (currentWaypoint + 1) % waypoints.Length; // Move to the next waypoint
        }
    }
}
