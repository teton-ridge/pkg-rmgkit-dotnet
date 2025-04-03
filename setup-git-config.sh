#!/bin/bash

# Set push configuration to prevent accidental tag pushing
git config --local push.followTags false
git config --local push.default simple

# Configure git to never fetch tags automatically
git config --local fetch.tags false
git config --local remote.origin.tagOpt --no-tags

# Configure git push to never push tags by default
git config --local advice.pushNonFFCurrent false

# This is the key setting - create an alias for push that always includes --no-tags
git config --local alias.push 'push --no-tags'

echo "Git configuration complete in the local repository."
echo "Tags will not be pushed or fetched by default. Tags are managed by CI/CD."
echo ""
echo "✅ You can now use 'git push' normally - it will automatically use --no-tags"
echo "✅ For pulls, use: git pull --no-tags" 