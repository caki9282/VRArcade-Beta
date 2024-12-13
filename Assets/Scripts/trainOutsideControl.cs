using UnityEngine;

public class LeverTrainController : MonoBehaviour
{
    [Header("Lever Settings")]
    public Transform lever; // The lever object
    public float minLeverAngle = -45f; // Lever's minimum rotation
    public float maxLeverAngle = 45f;  // Lever's maximum rotation

    [Header("Train Settings")]
    public Transform train;           // The train object
    public Transform[] waypoints;     // Path waypoints
    public float trainSpeed = 5f;     // Maximum train speed

    private float leverNormalized = 0f; // Normalized lever value
    private int currentWaypoint = 0;    // Current waypoint index

    void Update()
    {
        if (lever != null && train != null && waypoints.Length > 1)
        {
            // Get and normalize the lever's rotation
            float leverAngle = lever.localEulerAngles.x;
            leverAngle = NormalizeAngle(leverAngle);
            leverNormalized = Mathf.InverseLerp(minLeverAngle, maxLeverAngle, leverAngle);

            // Move the train along the path
            MoveTrain();
        }
    }

    private void MoveTrain()
    {
        if (currentWaypoint < waypoints.Length - 1)
        {
            // Calculate the target position based on waypoints
            Vector3 start = waypoints[currentWaypoint].position;
            Vector3 end = waypoints[currentWaypoint + 1].position;

            // Move the train towards the next waypoint
            train.position = Vector3.MoveTowards(
                train.position,
                end,
                leverNormalized * trainSpeed * Time.deltaTime
            );

            // Check if train reached the waypoint
            if (Vector3.Distance(train.position, end) < 0.1f)
            {
                currentWaypoint++;
            }
        }
    }

    // Normalize angles to the range [-180, 180]
    private float NormalizeAngle(float angle)
    {
        if (angle > 180f) angle -= 360f;
        return angle;
    }
}
