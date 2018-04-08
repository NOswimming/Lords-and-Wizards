using UnityEngine;

public static class HexMetrics
{
    /// <summary>
    /// Outer radius for a hexagon.
    /// Distance from the center of the hexagon to all corners.
    /// </summary>
    public const float outerRadius = 10f;

    /// <summary>
    /// Inner radius for a hexagon relative to the outer radius.
    /// Distance from the center of the hexagon to the center of all sides.
    /// </summary>
    public const float innerRadius = outerRadius * 0.866025404f;

    /// <summary>
    /// Positions for the corners relative to the center point (0,0).
    /// Corners are listed in a clockwise direction starting from the top (12) in a positive z-axis direction.
    /// Corners as positions of hours on a clock: 12, 2, 4, 6, 8, 10, 12.
    /// Note that there are 7 corners with last being at the starting position (12) for iterating through.
    /// </summary>
    public static Vector3[] corners = {
        new Vector3(0f, 0f, outerRadius),
        new Vector3(innerRadius, 0f, 0.5f * outerRadius),
        new Vector3(innerRadius, 0f, -0.5f * outerRadius),
        new Vector3(0f, 0f, -outerRadius),
        new Vector3(-innerRadius, 0f, -0.5f * outerRadius),
        new Vector3(-innerRadius, 0f, 0.5f * outerRadius),
        new Vector3(0f, 0f, outerRadius)
    };
}