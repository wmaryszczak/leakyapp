
### Leakyapp

The client application (LeakyAppClient) should me fixed to get rid the memory leak observer during the performance test


### Performance test

Run it on Mac or Linux machine

```
wrk -t12 -c400 -d30s http://127.0.0.1:5000/api/data
```


### History

* Returning hello world text
```
Running 30s test @ http://127.0.0.1:5000/api/data
  12 threads and 400 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency    70.86ms   23.85ms 361.98ms   89.44%
    Req/Sec   468.43     90.59   700.00     73.49%
  166908 requests in 30.07s, 25.95MB read
  Socket errors: connect 0, read 276, write 0, timeout 0
Requests/sec:   5549.74
Transfer/sec:      0.86MB
```
