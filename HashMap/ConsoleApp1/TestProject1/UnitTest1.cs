using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void SetAndGetKeyValue_ShouldWork()
        {
            // Arrange
            var hashMap = new HashMap(10);

            // Act
            hashMap.Set("key1", "value1");
            hashMap.Set("key2", "value2");

            // Assert
            Assert.Equal("value1", hashMap.Get("key1"));
            Assert.Equal("value2", hashMap.Get("key2"));
        }

        [Fact]
        public void GetNonExistentKey_ShouldReturnNull()
        {
            // Arrange
            var hashMap = new HashMap(10);

            // Act & Assert
            Assert.Null(hashMap.Get("nonexistent_key"));
        }

        [Fact]
        public void GetUniqueKeys_ShouldReturnListOfKeys()
        {
            // Arrange
            var hashMap = new HashMap(10);
            hashMap.Set("key1", "value1");
            hashMap.Set("key2", "value2");
            hashMap.Set("key3", "value3");

            // Act
            var keys = hashMap.Key();

            // Assert
            Assert.Contains("key1", keys);
            Assert.Contains("key2", keys);
            Assert.Contains("key3", keys);
            Assert.Equal(3, keys.Count);
        }

        [Fact]
        public void HandleCollision_ShouldWork()
        {
            // Arrange
            var hashMap = new HashMap(10);

            // Set two keys that will collide
            hashMap.Set("key1", "value1");
            hashMap.Set("key11", "value11");

            // Act & Assert
            Assert.Equal("value1", hashMap.Get("key1"));
            Assert.Equal("value11", hashMap.Get("key11"));
        }

        [Fact]
        public void RetrieveValueFromCollisionBucket_ShouldWork()
        {
            // Arrange
            var hashMap = new HashMap(10);

            // Set two keys that will collide
            hashMap.Set("key1", "value1");
            hashMap.Set("key11", "value11");

            // Act & Assert
            var keys1 = hashMap.Get("key1");
            var keys11 = hashMap.Get("key11");

            Assert.Equal("value1", keys1);
            Assert.Equal("value11", keys11);
        }

        [Fact]
        public void HashKeyToInRangeValue_ShouldWork()
        {
            // Arrange
            var hashMap = new HashMap(10);

            // Act
            int hashValue = hashMap.Hash("key1");

            // Assert
            Assert.InRange(hashValue, 0, 9); // Ensure hashValue is in the range of 0-9 for a size 10 map
        }
    }
}