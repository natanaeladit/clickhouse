# grafana

```
docker volume create grafana-storage
docker-compose up
```

install clickhouse plug-in

```
docker exec -it clickhouse_grafana_1 sh
grafana-cli plugins install vertamedia-clickhouse-datasource
```