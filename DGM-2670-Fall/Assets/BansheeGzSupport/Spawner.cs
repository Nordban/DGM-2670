using UnityEngine;
using BansheeGz.BGSpline.Components;
using BansheeGz.BGSpline.Curve;

/// <summary>
/// Create random spline and spawn several objects randomly along this spline
/// </summary>
public class Spawner : MonoBehaviour
{
    public int numberOfPoints = 3;
    public int numberOfObjects = 10;
    public GameObject prefab;

    void Start()
    {
        var newGameObject = new GameObject("BGCurve [generated]");
        var math = newGameObject.AddComponent<BGCcMath>();
        var curve = math.Curve;

        //add points
        for (var i = 0; i < numberOfPoints; i++)
        {
            var control = GetRandomVector(-5, 5);
            math.Curve.AddPoint(new BGCurvePoint(curve, GetRandomVector(-10, 10), BGCurvePoint.ControlTypeEnum.BezierSymmetrical, control, -control));
        }

        //add objects
        for (var i = 0; i < numberOfObjects; i++) Instantiate(prefab, math.CalcPositionByDistance(Random.Range(0, math.GetDistance())), Quaternion.identity);
    }

    private static Vector3 GetRandomVector(float min, float max)
    {
        return new Vector3(Random.Range(min, max), Random.Range(min, max), Random.Range(min, max));
    }
}