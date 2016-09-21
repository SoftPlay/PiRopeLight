#see https://www.visualstudio.com/en-gb/docs/integrate/api/overview

#builds
#GET 
#https://{instance}/DefaultCollection/{project}/_apis/build/builds?api-version={version}
#[&definitions={string}][&queues={string}][&buildNumber={string}][&type={string}]
#[&minFinishTime={DateTime}][&maxFinishTime={DateTime}][&requestedFor={string}]
#[&reasonFilter={string}][&statusFilter={string}][&tagFilters={string}][&propertyFilters={string}]
#[&$top={int}][&continuationToken={string}]
Invoke-RestMethod -UseDefaultCredentials `
	"http://tfs:8080/tfs/ApdCollection/ApdAgile/_apis/build/builds?api-version=2.0"

#releases
#GET 
#https://{account}.vsrm.visualstudio.com/defaultcollection/{project}/_apis/release/releases?api-version={version}
#[&definitionId={int}&createdBy={string}&maxCreatedTime={datetime}&minCreatedTime={datetime}
#&statusFilter={string}&$expand={enum}&$top={string}&queryOrder={string}&continuationToken={string}]
Invoke-RestMethod -UseDefaultCredentials `
	"https://tfs:8080/tfs/ApdCollection/ApdAgile/_apis/release/releases?api-version=3.0-preview.2"
