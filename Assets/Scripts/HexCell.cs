using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexCell : MonoBehaviour {

    public HexCoordinates coordinates;

    public Color color;

    [SerializeField]
    private HexCell[] neighbors;

    public HexCell GetNeighbour (HexDirection direction)
    {
        return neighbors[(int)direction];
    }

    public void setNeighbor(HexDirection direction, HexCell cell)
    {
        neighbors[(int)direction] = cell;
        cell.neighbors[(int)direction.Opposite()] = this;
    }
}
