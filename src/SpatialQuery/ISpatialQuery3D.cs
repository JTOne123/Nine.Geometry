﻿namespace Nine.Geometry.SpatialQuery
{
    using System;

    public interface ISpatialQuery3D<T>
    {
        /// <summary>
        /// Put all objects that is potentially hits the ray
        /// into the result array starting from startIndex. Resizes the result array if it 
        /// cannot hold more results.
        /// Returns the count of objects added to the result array.
        /// </summary>
        /// <param name="callback">
        /// An optional callback handler that returns the distance to the potential target. Returns float.NaN to stop the raycast.
        /// </param>
        int Raycast(ref Ray ray, ref RaycastHit<T>[] result, int startIndex, Func<T, float> callback = null);

        /// <summary>
        /// Put all objects that is potentially inside or intersects with the bounding box
        /// into the result array starting from startIndex. Resizes the result array if it 
        /// cannot hold more results.
        /// Returns the count of objects added to the result array.
        /// </summary>
        int FindAll(ref BoundingBox bounds, ref T[] result, int startIndex);
    }
}
