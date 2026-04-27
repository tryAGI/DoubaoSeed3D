#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained from public Seed3D and Volcano Ark task API references.

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace DoubaoSeed3D \
  --clientClassName DoubaoSeed3DClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
