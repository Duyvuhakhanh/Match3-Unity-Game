using System.Collections.Generic;
using UnityEngine;

namespace Utility
{
    public static class CellPooling
    {

        private static readonly Queue<Cell> cellPoolQueue = new Queue<Cell>();
        public static Cell GetCell(Transform root, Cell prefab)
        {
            Cell cell = null;
            cell = cellPoolQueue.Count > 0 ? cellPoolQueue.Dequeue() : Object.Instantiate(prefab, root);
            cell.transform.SetParent(root);
            cell.gameObject.SetActive(true);

            return cell;

        }
        public static void ReturnCell(Cell cell)
        {
            cell.transform.parent = null;
            cell.gameObject.SetActive(false);
            if (cellPoolQueue.Contains(cell))
            {
                return;
            }

            cellPoolQueue.Enqueue(cell);
        }
    }
}
