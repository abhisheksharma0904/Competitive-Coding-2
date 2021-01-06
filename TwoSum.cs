//TC - O(log n) where n is number of elements in array.
//SC - O(n) 
  
  public static int[] findIndexes(int[] arr, int target)
        {
            int[] result = new int[2];
            result[1] = -1;
            result[0] = -1;
            IDictionary<int, int> map = new Dictionary<int, int>();
            for(int i = 0; i < arr.Length; i++)
            {
                int temp = target - arr[i];
                if (map.ContainsKey(temp)){
                    
                    result[0] = map[temp];
                    result[1] = i;
                    return result;
                }
                map.Add(arr[i], i);
            }
            return result;

        }
